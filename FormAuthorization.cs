using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookStore.Models;
using System.Linq;
namespace BookStore
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        //Авторизация
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (AllValid())
            {
                var loginInfo = (from user in ClassGetContext.context.Users
                            join worker in ClassGetContext.context.Workers on user.idWorker equals worker.idWorker
                            where user.login == tbLogin.Text && user.password == tbPassword.Text
                            select new { worker.position, worker.idWorker }).FirstOrDefault();

                if (loginInfo != null)
                {
                    ClassActiveUser.WorkerId = loginInfo.idWorker;

                    switch (loginInfo.position)
                    {
                        case "Продавец-консультант":
                            {
                                var formSales = new FormSales();
                                formSales.Show();
                                break;
                            }
                        case "Кладовщик":
                            {
                                var formWarehouseman = new FormWarehouseman();
                                formWarehouseman.Show();
                                break;
                            }
                    }
                    Hide();
                }
                else MessageBox.Show("Такого пользователя не существует, проверьте введенные вами данные");
            }
            else MessageBox.Show("Не все данные введены");                    
        }
        //Показать или скрыть пароль
        private void chbShowHidePass_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = chbShowHidePass.Checked ? '\0': '*';          
        }
        //Закрытие формы
        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Проверка на пустые поля
        private bool AllValid()
        {
            if (!string.IsNullOrWhiteSpace(tbLogin.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                return true;
            }
            return false;
        }
    }
}
