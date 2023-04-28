using Repository.Model;

namespace BooksHomework
{
    public partial class AddForm : Form
    {
        private MainForm mainForm;

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Book book = new Book();
                book.Name = txtBoxName.Text.Trim();
                book.Surname = txtBoxSurname.Text.Trim();
                book.Title = txtBoxTitle.Text.Trim();
                book.Id = mainForm.books.Count + 1;

                Writer writer = new Writer();
                writer.Name = txtBoxName.Text.Trim();
                writer.Surname = txtBoxSurname.Text.Trim();

                if (mainForm.books.Any(b => b.Name == book.Name && b.Surname == book.Surname && b.Title == book.Title))
                    MessageBox.Show("There is a same book with the same writer in the directory.");
                else
                {
                    mainForm.books.Add(book);
                    MessageBox.Show("New book has been added.");
                }
                if (!mainForm.writers.Any(w => w.Name == writer.Name && w.Surname == writer.Surname))
                {
                    mainForm.writers.Add(writer);
                }
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
