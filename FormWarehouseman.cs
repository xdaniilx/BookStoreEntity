using System;
using System.Windows.Forms;
namespace BookStore
{
    public partial class FormWarehouseman : Form
    {
        public FormWarehouseman()
        {
            InitializeComponent();
        }
        //Загрузка формы
        private void FormWarehouseman_Load(object sender, EventArgs e)
        {
            cbCategorySearch.SelectedIndex = 0;

            ClassFillTable.FillTable(tableBooks);
            ClassFillBookInfo.FillBookInfo(tableBooks, pictureBoxCover, lblParamGenre, lblParamAuthor,
            lblParamNameBook, lblParamYearPublishing, lblParamCoverType, lblParamPublishing,
            lblParamPageCount, lblParamAgeLimit, lblParamISBN, richTextBoxDescription);
        }
        //Работа с поиском
        //Изменение типа поиска
        private void cbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSearch.FillComboBoxSearch(cbCategorySearch, cbSearch);
        }
        //Поиск
        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            ClassSearch.Search(cbCategorySearch.SelectedIndex, cbSearch, tableBooks);
        }
        //Очистка поля поиска
        private void pictureBoxErase_Click(object sender, EventArgs e)
        {
            ClassSearch.Erase(cbCategorySearch, cbSearch);
            ClassFillTable.FillTable(tableBooks);
        }
        //Показ информации о книге
        private void tableBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassFillBookInfo.FillBookInfo(tableBooks, pictureBoxCover, lblParamGenre, lblParamAuthor,
            lblParamNameBook, lblParamYearPublishing, lblParamCoverType, lblParamPublishing,
            lblParamPageCount, lblParamAgeLimit, lblParamISBN, richTextBoxDescription);
        }
        //ПЕРЕХОДЫ НА ФОРМЫ
        //Переход на форму авторов
        private void menuItemAuthors_Click(object sender, EventArgs e)
        {
            var formGenresPublishingAuthors = new FormGenresPublishingAuthors("authors");
            formGenresPublishingAuthors.Show();
            Hide();
        }
        //Переход на форму жанров
        private void menuItemGenres_Click(object sender, EventArgs e)
        {
            var formGenresPublishingAuthors = new FormGenresPublishingAuthors("genres");
            formGenresPublishingAuthors.Show();
            Hide();
        }
        //Переход на форму издательств
        private void menuItemPublishing_Click(object sender, EventArgs e)
        {
            var formGenresPublishingAuthors = new FormGenresPublishingAuthors("publishing");
            formGenresPublishingAuthors.Show();
            Hide();
        }     
        //Переход на форму оформления поступления
        private void menuItemNewArrival_Click(object sender, EventArgs e)
        {
            var fAddArrival = new FormAddArrival();
            fAddArrival.Show();
            Close();
        }
        //Переход на форму изменения информации о книге
        private void buttonEditInformation_Click(object sender, EventArgs e)
        {
            var fAddBook = new FormAddBook(Convert.ToInt32(tableBooks.CurrentRow.Cells[0].Value), "Edit");
            fAddBook.Show();
            Hide();
        }
        //Выход на форму авторизации
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            var formAuthorization = new FormAuthorization();
            formAuthorization.Show();
            Hide();
        }
        //Переход на форму оформления поступления
        private void MenuItemAddArrival_Click(object sender, EventArgs e)
        {
            var fAddArrival = new FormAddArrival();
            fAddArrival.Show();
            Hide();
        }
        //Переход на форму всех поступлений
        private void поступленияКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fReport = new FormReport("arrival");
            fReport.Show();
            Hide();
        }
        //Переход на форму всех продаж
        private void MenuItemReportSell_Click(object sender, EventArgs e)
        {
            var fReport = new FormReport("sell");
            fReport.Show();
            Hide();
        }
        //Переход на форму популярных книг
        private void MenuItemPopularBook_Click(object sender, EventArgs e)
        {
            var fReport = new FormReport("popularbook");
            fReport.Show();
            Hide();
        }
        private void FormWarehouseman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }          
}
