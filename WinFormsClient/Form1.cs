using Grpc.Net.Client;
using NTQTRAINING_PRJ.Protos;
using System.Data;
using System.Globalization;
using System.Reflection;

namespace WinFormsClient
{
    //static  GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5009");
    //static client = new CategoriesSevices.CategoriesSevicesClient(channel);
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5009");
        static CategoriesSevices.CategoriesSevicesClient client = new CategoriesSevices.CategoriesSevicesClient(channel);
        private void Form1_Load(object sender, EventArgs e)
        {

            var listCategory = client.GetAll(new CategoryEmpty());
            dgvCategory.DataSource = ToDataTable(listCategory);
        }

        private DataTable ToDataTable(ListCategory listData)
        {
            DataTable dt = new DataTable();

            PropertyInfo[] Props = typeof(Category).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dt.Columns.Add(prop.Name);
            }

            foreach (var item in listData.Items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtId.Text = dgvCategory.Rows[index].Cells["Id"].Value.ToString();
            txtName.Text = dgvCategory.Rows[index].Cells["Name"].Value.ToString();
            txtTagName.Text = dgvCategory.Rows[index].Cells["TagName"].Value.ToString();
            if (dgvCategory.Rows[index].Cells["Active"].Value.ToString() == "True")
            {
                checkBoxActive.Checked = true;
            }
            else
            {
                checkBoxActive.Checked = false;
            }



            //dateTimeCreate.Text = DateTime.ParseExact(dgvCategory.Rows[index].Cells["CreatedDate"].Value.ToString(), "yyyy-MM-dd T HH:mm:ss", CultureInfo.InvariantCulture).ToString() ;
            //DateTime dateTime = dgvCategory.Rows[index].Cells["UpdatedDate"].Value.
            //dateTimeUpdate.Text = dateTime.ToString();

            //DateTime.ParseExact(row.Cells[3].Value, "dd-MM-yyyy", CultureInfo.InvariantCulture)
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtName.Text;
            category.TagName = txtTagName.Text;
            if(checkBoxActive.Checked)
            {
                category.Active = true;
            }
            else
            {
                category.Active = false;
            }
            category.CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeCreate.Value, DateTimeKind.Utc));
            category.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeUpdate.Value, DateTimeKind.Utc));
            
            ResponseSesult repon = client.Create(category);
            if(repon.Result==true)
            {
                MessageBox.Show("Create Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Create Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CategoryId categoryID = new CategoryId();
            categoryID.Id = int.Parse(txtId.Text);
            client.Delete(categoryID);
            Form1_Load(sender, e);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CategoryId categoryID = new CategoryId();
            categoryID.Id = int.Parse(txtId.Text);
            ResponseSesult newRespon = client.GetCategoryById(categoryID);
            newRespon.Item.Id=int.Parse(txtId.Text);
            newRespon.Item.Name = txtName.Text;
            newRespon.Item.TagName = txtTagName.Text;
            if (checkBoxActive.Checked)
            {
                newRespon.Item.Active = true;
            }
            else
            {
                newRespon.Item.Active = false;
            }
            newRespon.Item.CreatedDate= Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeCreate.Value, DateTimeKind.Utc));
            newRespon.Item.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeUpdate.Value, DateTimeKind.Utc));
            
            ResponseSesult responseSesult = client.Update(newRespon.Item);
            if (responseSesult.Result == true)
            {
                MessageBox.Show("Update Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Update Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            CategoryId categoryID = new CategoryId();
            categoryID.Id = int.Parse(txtSearch.Text);
            ResponseSesult newRespon = client.GetCategoryById(categoryID);

            ListCategory listCategory = new ListCategory();
            listCategory.Items.Add(newRespon.Item);
            dgvCategory.DataSource = ToDataTable(listCategory);
        }
    }
}