using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using Repository.Model;

namespace BooksHomework
{
    public partial class Form1 : Form
    {
        IWebDriver driver = null;
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        // Load the Form
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            await LoadForm();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                List<Book> matchedBooks = books.Where(b => b.Name.Contains(txtBoxSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                b.Title.Contains(txtBoxSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                b.Surname.Contains(txtBoxSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                b.Title.Contains(txtBoxSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                matchedBooks = matchedBooks.Distinct().ToList();
                //dataGridView1.DataSource = matchedBooks;

                dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.DataSource = matchedBooks;
                    lblDisplayed.Text = matchedBooks.Count.ToString();
                });
            });
        }

        private async Task LoadForm()
        {
            await Task.Run(async () =>
            {
                // Driver Options
                string driverPath = @"..\..\..\bin\Debug";
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");

                using (ChromeDriver driver = new ChromeDriver(driverPath, options))
                {
                    driver.Navigate().GoToUrl("https://www.goodreads.com/list/show/18834.BBC_Top_200_Books");

                    WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    IReadOnlyCollection<IWebElement> bookElements = wait10.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("tr")));

                    int id = 0;
                    foreach (var book in bookElements)
                    {
                        id++;
                        string title = book.FindElement(By.ClassName("bookTitle")).FindElement(By.TagName("span")).Text;
                        string writer = book.FindElement(By.ClassName("authorName")).FindElement(By.TagName("span")).Text;
                        var nameSurname = writer.Split(" ");
                        string name = "";
                        string surname = null;
                        for (int i = 0; i < nameSurname.Length - 1; i++)
                        {
                            name += nameSurname[i] + " ";
                        }
                        name = name.TrimEnd(' ');
                        surname = nameSurname[nameSurname.Length - 1];

                        books.Add(new Book { Id = id, Name = name, Surname = surname, Title = title });
                    }
                }

                if (dataGridView1.IsHandleCreated)
                {
                    dataGridView1.Invoke((MethodInvoker)delegate ()
                    {
                        dataGridView1.DataSource = books;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        AcceptButton = btnSearch;

                        lblDisplayed.Text = books.Count().ToString();
                    });
                }
            });
        }
    }
}