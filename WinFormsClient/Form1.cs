using Grpc.Net.Client;
using NTQTRAINING_PRJ.Protos;
using System.Data;
using System.Reflection;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5009");
            var client = new CategoriesSevices.CategoriesSevicesClient(channel);
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

    }
}