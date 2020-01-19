using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
namespace BookStore
{
    class ClassFillBookInfo
    {
        public static void FillBookInfo(DataGridView tableBooks, PictureBox pictureBoxCover, 
            Label lblParamGenre, Label lblParamAuthor, Label lblParamNameBook, Label lblParamYearPublishing,
            Label lblParamCoverType, Label lblParamPublishing, Label lblParamPageCount, Label lblParamAgeLimit, Label lblParamISBN,
            RichTextBox richTextBoxDescription)
        {
            using (SqlConnection connection = ClassConnection.SqlConnection())
            {
                connection.Open();

                lblParamGenre.Text = "";
                lblParamAuthor.Text = "";
                lblParamNameBook.Text = tableBooks.CurrentRow.Cells[1].Value.ToString();

                var commandAuthor = new SqlCommand(@"SELECT Author.idAuthor, Author.shortName 
                FROM [Author], [Book], [BookAuthor] 
                WHERE Book.idBook = '" + tableBooks.CurrentRow.Cells[0].Value.ToString() + "' AND Author.idAuthor = BookAuthor.idAuthor AND BookAuthor.idBook = Book.idBook", connection);
                var readerAuthor = commandAuthor.ExecuteReader();
                if (readerAuthor.HasRows)
                {
                    while (readerAuthor.Read())
                    {
                        lblParamAuthor.Text += readerAuthor[1].ToString() + "  ";
                    }
                    readerAuthor.Close();
                }
                readerAuthor.Close();

                var commandGenre = new SqlCommand(@"SELECT Genre.idGenre, Genre.genre 
                FROM [Genre], [Book], [BookGenre] 
                WHERE Book.idBook = '" + tableBooks.CurrentRow.Cells[0].Value.ToString() + "' AND Genre.idGenre = BookGenre.idGenre AND Book.idBook = BookGenre.idBook", connection);
                var readerGenre = commandGenre.ExecuteReader();
                if (readerGenre.HasRows)
                {
                    while (readerGenre.Read())
                    {
                        lblParamGenre.Text += readerGenre[1].ToString() + "  ";
                    }
                    readerGenre.Close();
                }
                readerGenre.Close();

                SqlCommand commandBookInfo = new SqlCommand(@"SELECT
                Book.yearOfPublishing, Book.CoverType, Publishing.namePublishing, Book.pageCount,
                Book.ageLimit, Book.ISBN, Book.description, Book.cover
                FROM [Book], [Author], [BookAuthor], [Genre], [BookGenre], [Publishing]
                WHERE Book.idBook = '" + tableBooks.CurrentRow.Cells[0].Value.ToString() + "' AND " +
                "Author.idAuthor = BookAuthor.idAuthor AND " +
                "BookAuthor.idBook = Book.idBook AND " +
                "Genre.idGenre = BookGenre.idGenre AND " +
                "Book.idBook = BookGenre.idBook AND " +
                "Book.idPublishing = Publishing.idPublishing", connection);

                SqlDataReader reader = commandBookInfo.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                                              
                        lblParamYearPublishing.Text = reader[0].ToString();
                        lblParamCoverType.Text = reader[1].ToString();
                        lblParamPublishing.Text = reader[2].ToString();
                        lblParamPageCount.Text = reader[3].ToString();
                        lblParamAgeLimit.Text = reader[4].ToString();
                        lblParamISBN.Text = reader[5].ToString();
                        richTextBoxDescription.Text = reader[6].ToString();

                        string path = reader[7].ToString();
                        if (path != "")
                        {
                            Bitmap image = new Bitmap(path);
                            pictureBoxCover.Image = image;
                        }
                        else
                        {
                            pictureBoxCover.Image = pictureBoxCover.ErrorImage;
                        }
                    }
                    reader.Close();
                }
            }
        }
    }
}
