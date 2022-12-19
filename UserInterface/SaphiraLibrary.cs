using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class SaphiraLibrary : Form
    {
        IBookService _bookService;
        ICategoryService _categoryService;
        IAuthorService _authorService;
        ICustomerService _customerService;
        IRentalService _rentalService;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public SaphiraLibrary()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _rentalService = InstanceFactory.GetInstance<IRentalService>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategoris();
            LoadAuthor();
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            dgwCustomer.DataSource = _customerService.GetAll();
            cbxMüsteriAdıKiralama.DataSource = _customerService.GetAll();
            cbxMüsteriAdıKiralama.DisplayMember = "CustomerName";
            cbxMüsteriAdıKiralama.ValueMember = "Id";
            dgwCustomer.Columns[0].Visible = false;
            dgwCustomer.Columns[1].HeaderCell.Value = "Müşteri Ad Soyad";
            dgwCustomer.Columns[2].HeaderCell.Value = "Meslek";
            dgwCustomer.Columns[3].HeaderCell.Value = "Cinsiyet";
            dgwCustomer.Columns[4].HeaderCell.Value = "Yaş";
            dgwCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwCustomer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwCustomer.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwCustomer.ReadOnly = true;
            _logger.Info("Müşteriler yüklendi");
        }
        private void LoadBooks()
        {
            dgwBook.DataSource = _bookService.GetAll();
            cbxKitapAdıKiralama.DataSource = _bookService.GetAll();
            cbxKitapAdıKiralama.DisplayMember = "BookName";
            cbxKitapAdıKiralama.ValueMember = "Id";
            dgwBook.Columns[0].Visible = false;
            dgwBook.Columns[1].Visible = false;
            dgwBook.Columns[2].Visible = false;
            dgwBook.Columns[3].HeaderCell.Value = "Kitap Adı";
            dgwBook.Columns[4].HeaderCell.Value = "Fiyat";
            dgwBook.Columns[5].HeaderCell.Value = "Sayfa Sayısı";
            dgwBook.Columns[6].HeaderCell.Value = "Yayınevi";
            //alanlardaki bilgiye göre sütunlar otomatik ayarlıyor.
            dgwBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //başlık çizgilerini kaldırma
            dgwBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //satırdaki çizgileri kaldırma
            dgwBook.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //sütundaki çizgileri kaldırma
            dgwBook.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //hücredeki verilerde değişiklik yapılmasını engelleme
            dgwBook.ReadOnly = true;
            //sütun başlıklarını fontunu, tipini ve boyutunu ayarlama
            dgwBook.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
        }

        private void LoadCategoris()
        {
            dgwKategori.DataSource = _categoryService.GetAll();
            dgwKategori.Columns[0].Visible = false;
            dgwKategori.Columns[1].HeaderCell.Value = "Kategori Adı";

            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";

            cmbxCategoryAdded.DataSource = _categoryService.GetAll();
            cmbxCategoryAdded.DisplayMember = "Name";
            cmbxCategoryAdded.ValueMember = "Id";
            dgwKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwKategori.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwKategori.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwKategori.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwKategori.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwKategori.ReadOnly = true;

        }

        private void LoadAuthor()
        {
            dgwYazar.DataSource = _authorService.GetAll();
            dgwYazar.Columns[0].Visible = false;
            dgwYazar.Columns[1].HeaderCell.Value = "Yazar Adı";

            cmbxAuthorAdded.DataSource = _authorService.GetAll();
            cmbxAuthorAdded.DisplayMember = "Writer";
            cmbxAuthorAdded.ValueMember = "Id";
            dgwYazar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwYazar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwYazar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwYazar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwYazar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwYazar.ReadOnly = true;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBook.DataSource = _bookService.GetByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
            }
        }

        private void txtAuthorSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAuthorSearch.Text))
            {
                dgwBook.DataSource = _bookService.GetByBookName(txtAuthorSearch.Text);
            }
            else
            {
                LoadBooks();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book
                {
                    CategoryId = Convert.ToInt32(cmbxCategoryAdded.SelectedValue),
                    AuthorId = Convert.ToInt32(cmbxAuthorAdded.SelectedValue),
                    BookName = txtBookName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    PageCount = Convert.ToInt32(txtPageCount.Text),
                    Publisher = txtPublisher.Text
                });
                MessageBox.Show("Kitap sisteme eklenmiştir.", "Kitap işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bookService.Update(new Book
            {
                Id = Convert.ToInt32(dgwBook.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cmbxCategoryAdded.SelectedValue),
                AuthorId = Convert.ToInt32(cmbxAuthorAdded.SelectedValue),
                BookName = txtBookName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                PageCount = Convert.ToInt32(txtPageCount.Text),
                Publisher = txtPublisher.Text
            });
            MessageBox.Show("Kitap güncellenmiştir.", "Kitap işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBooks();
        }

        private void dgwBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbxAuthorAdded.SelectedValue = dgwBook.CurrentRow.Cells[1].Value;
            cmbxCategoryAdded.SelectedValue = dgwBook.CurrentRow.Cells[2].Value;
            txtBookName.Text = dgwBook.CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = dgwBook.CurrentRow.Cells[4].Value.ToString();
            txtPageCount.Text = dgwBook.CurrentRow.Cells[5].Value.ToString();
            txtPublisher.Text = dgwBook.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwBook.CurrentRow != null)
            {
                _bookService.Delete(new Book
                {
                    Id = Convert.ToInt32(dgwBook.CurrentRow.Cells[0].Value)
                });
            }
            MessageBox.Show("Kitap bilgisi silinsin mi?", "Kitap işlemleri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            LoadBooks();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category
                {
                    Name = txtKategori.Text
                });
                MessageBox.Show("Kategori sisteme eklenmiştir.", "Kategori işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoris();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnKategoriGüncelle_Click(object sender, EventArgs e)
        {
            _categoryService.Update(new Category
            {
                Id = Convert.ToInt32(dgwKategori.CurrentRow.Cells[0].Value),
                Name = txtKategori.Text
            });
            MessageBox.Show("Kategori güncellenmiştir.", "Kategori işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategoris();
        }

        private void dgwKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategori.Text = dgwKategori.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text != null)
            {
                _categoryService.Delete(new Category
                {
                    Id = Convert.ToInt32(dgwKategori.CurrentRow.Cells[0].Value)
                });
            }
            MessageBox.Show("Kategori bilgisi silinsin mi?", "Kategori işlemleri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            LoadCategoris();
        }

        private void dgwYazar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYazar.Text = dgwYazar.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Add(new Author
                {
                    Writer = txtYazar.Text
                });
                MessageBox.Show("Yazar sisteme eklenmiştir.", "Yazar işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAuthor();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnYazarGüncelle_Click(object sender, EventArgs e)
        {
            _authorService.Update(new Author
            {
                Id = Convert.ToInt32(dgwYazar.CurrentRow.Cells[0].Value),
                Writer = txtYazar.Text
            });
            MessageBox.Show("Yazar güncellenmiştir.", "Yazar işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAuthor();
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            _authorService.Delete(new Author
            {
                Id = Convert.ToInt32(dgwYazar.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Yazar bilgisi silinsin mi?", "Yazar işlemleri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            LoadAuthor();
        }

        private void btnKitapListeleme_Click(object sender, EventArgs e)
        {
            dgwListeleme.DataSource = _bookService.GetBookDetails();
            dgwListeleme.Columns[0].Visible = false;
            dgwListeleme.Columns[1].HeaderCell.Value = "Yazar Adı";
            dgwListeleme.Columns[2].HeaderCell.Value = "Kategori Adı";
            dgwListeleme.Columns[3].HeaderCell.Value = "Kitap Adı";
            dgwListeleme.Columns[4].HeaderCell.Value = "Fiyat";
            dgwListeleme.Columns[5].HeaderCell.Value = "Sayfa Sayısı";
            dgwListeleme.Columns[6].HeaderCell.Value = "Yayınevi";
            dgwListeleme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwListeleme.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwListeleme.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwListeleme.ReadOnly = true;
        }

        private void btnKategoriListeleme_Click(object sender, EventArgs e)
        {
            dgwListeleme.DataSource = _categoryService.GetAll();
            dgwListeleme.Columns[0].Visible = false;
            dgwListeleme.Columns[1].HeaderCell.Value = "Kategori Adı";
            dgwListeleme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwListeleme.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwListeleme.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwListeleme.ReadOnly = true;
        }

        private void btnYazarListeleme_Click(object sender, EventArgs e)
        {
            dgwListeleme.DataSource = _authorService.GetAll();
            dgwListeleme.Columns[0].Visible = false;
            dgwListeleme.Columns[1].HeaderCell.Value = "Yazar Adı";
            dgwListeleme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwListeleme.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwListeleme.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwListeleme.ReadOnly = true;
        }

        private void btnCustomerAdded_Click(object sender, EventArgs e)
        {
            if (rbErkek.Checked == true)
            {
                lblCustomerGender.Text = rbErkek.Text;
            }
            else
            {
                lblCustomerGender.Text = rbKadın.Text;
            }
            _customerService.Add(new Customer
            {
                CustomerName = txtCustomerName.Text,
                Job = txtCustomerJob.Text,
                Gender = lblCustomerGender.Text,
                Age = Convert.ToInt32(txtCustomerAge.Text)
            });
            MessageBox.Show("Müşteri sisteme eklenmiştir.", "Müşteri işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomer();
        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = dgwCustomer.CurrentRow.Cells[1].Value.ToString();
            txtCustomerJob.Text = dgwCustomer.CurrentRow.Cells[2].Value.ToString();
            txtCustomerAge.Text = dgwCustomer.CurrentRow.Cells[4].Value.ToString();
            //equals 2 nesnenin örneğinin eşit olup olmadığını belirler.
            if (this.dgwCustomer.CurrentRow.Cells[3].Value.Equals("Erkek"))
            {
                rbErkek.Checked = true;
            }
            else
            {
                rbKadın.Checked = true;
            }
        }

        private void btnCustomerUpdated_Click(object sender, EventArgs e)
        {
            if (rbErkek.Checked == true)
            {
                lblCustomerGender.Text = rbErkek.Text;
            }
            else
            {
                lblCustomerGender.Text = rbKadın.Text;
            }
            _customerService.Update(new Customer
            {
                Id = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value),
                CustomerName = txtCustomerName.Text,
                Job = txtCustomerJob.Text,
                Gender = lblCustomerGender.Text,
                Age = Convert.ToInt32(txtCustomerAge.Text)
            });
            MessageBox.Show("Müşteri güncellenmiştir.", "Müşteri işlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomer();
        }

        private void btnCustomerRemove_Click(object sender, EventArgs e)
        {
            _customerService.Delete(new Customer
            {
                Id = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Müşteri bilgisi silinsin mi?", "Müşteri işlemleri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            LoadCustomer();
        }

        private void btnKitapKirala_Click(object sender, EventArgs e)
        {
            try
            {
                _rentalService.Add(new Rental
                {
                    //seçilen verinin id bilgisini getiriyor.
                    BookId = Convert.ToInt32(cbxKitapAdıKiralama.SelectedValue),
                    CustomerId = Convert.ToInt32(cbxMüsteriAdıKiralama.SelectedValue),
                    RentDate = dpRentDate.Value,
                    ReturnDate = dpDonusDate.Value
                });
                MessageBox.Show("Kitap başarılı olarak kiralanmıştır.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwListeleme.DataSource = _rentalService.GetRentalDetails();
            dgwListeleme.Columns[0].Visible = false;
            dgwListeleme.Columns[1].HeaderCell.Value = "Kitap Adı";
            dgwListeleme.Columns[2].HeaderCell.Value = "Müşteri Adı";
            dgwListeleme.Columns[3].HeaderCell.Value = "Kiralama Tarihi";
            dgwListeleme.Columns[4].HeaderCell.Value = "Bitiş Tarihi";
            dgwListeleme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwListeleme.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwListeleme.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwListeleme.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dgwListeleme.ReadOnly = true;
        }
    }
}