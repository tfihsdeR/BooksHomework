using Repository.Model;
using System.Windows.Forms;

namespace BooksHomework
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                MainForm mainForm = new MainForm();
                List<Book> books = mainForm.books;
                List<Writer> writers = mainForm.writers;

                Book book = new Book();
                book.Name = txtBoxName.Text.Trim();
                book.Surname = txtBoxSurname.Text.Trim();
                book.Title = txtBoxTitle.Text.Trim();

                Writer writer = new Writer();
                writer.Name = txtBoxName.Text.Trim();
                writer.Surname = txtBoxSurname.Text.Trim();

                if (books.Any(b => b.Name == book.Name && b.Surname == book.Surname && b.Title == book.Title))
                    MessageBox.Show("There is a same book with the same writer in the directory.");
                else
                {
                    books.Add(book);
                    MessageBox.Show("New book has been added.");
                }
                if (!writers.Any(w => w.Name == writer.Name && w.Surname == writer.Surname))
                {
                    writers.Add(writer);
                }

                mainForm.UpdateDataGridView(books);
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
