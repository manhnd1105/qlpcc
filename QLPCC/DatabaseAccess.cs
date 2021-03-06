using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel.Design;

namespace QLPCC
{
   public class DatabaseAccess
   {     
       #region "Biến cục bộ"
       public static OleDbConnection MyConnect;
       #endregion
       #region "Tạo kết nối"
       public static void CreateConnect()
       {
           String stringConnect = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                           //"Data Source =" + Application.StartupPath + @"..\..\..\database.pcc;" + //Debug
                           "Data Source =" + Application.StartupPath + @"\database.pcc;" + //Install
                           "Jet OLEDB:Database Password = cuonglv;" +
                           "User ID = admin";
           MyConnect = new OleDbConnection();
           MyConnect.ConnectionString = stringConnect;
           MyConnect.Open();
       }
       #endregion
       #region "Hủy kết nối"
       public static void DestroyConnect()
       {
            MyConnect.Close(); //Đóng kết nối
            MyConnect.Dispose(); //Giải phóng tài nguyên
            MyConnect = null; //Hủy đối tượng
       }
       #endregion
       #region "SELECT dữ liệu đổ vào DataTable"
       public static void Select_HasNoParameter(string Query_Select, DataTable MyTable)
       {

           //Tạo kết nối tới file Access
           CreateConnect();
           //Tạo đối tượng OledDBCommand
           OleDbCommand MyCommand = new OleDbCommand();
           //Gán tham số cho đối tượng OledDBCommand để thực hiện truy vấn dữ liệu từ CSDL            
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select; 
           MyCommand.Connection = MyConnect;
           //Tạo DataReader
           OleDbDataReader MyDataReader;
           //Cho DataReader nhận dữ liệu trả về của câu lệnh SQL vừa truy vấn
           MyDataReader = MyCommand.ExecuteReader();
           //Load DataReader vào DataTable
           MyTable.Load(MyDataReader);
           //Dùng xong thì hủy các đối tượng
           //Hủy đối tượng OleDBCommand
           MyCommand.Dispose();
           MyCommand = null;
           //Hủy đối tượng DataReader (phải close trước khi hủy)
           MyDataReader.Close();
           MyDataReader.Dispose();
           MyDataReader = null;
           //Hủy kết nối với CSDL
           DestroyConnect();
       }
       public static DataTable Select_HasNoParameter(string Query_Select)
       {

           //Tạo kết nối tới file Access
           CreateConnect();
           //Tạo đối tượng OledDBCommand
           OleDbCommand MyCommand = new OleDbCommand();
           //Gán tham số cho đối tượng OledDBCommand để thực hiện truy vấn dữ liệu từ CSDL            
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           MyCommand.Connection = MyConnect;
           //Tạo DataReader
           OleDbDataReader MyDataReader;
           //Cho DataReader nhận dữ liệu trả về của câu lệnh SQL vừa truy vấn
           MyDataReader = MyCommand.ExecuteReader();
           //Load DataReader vào DataTable
           DataTable MyTable = new DataTable();
           MyTable.Load(MyDataReader);
           //Dùng xong thì hủy các đối tượng
           //Hủy đối tượng OleDBCommand
           MyCommand.Dispose();
           MyCommand = null;
           //Hủy đối tượng DataReader (phải close trước khi hủy)
           MyDataReader.Close();
           MyDataReader.Dispose();
           MyDataReader = null;
           //Hủy kết nối với CSDL
           DestroyConnect();

           return MyTable;
       }
       public static void Select_HasManyParameter(string Query_Select,DataTable MyTable,string[] ParameterName,string[] ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
           for (int i = 0; i < ParameterName.Length;i++ )
           {
               MyCommand.Parameters.Add(ParameterName[i], OleDbType.VarChar).Value = ParameterValue[i];
           }
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataTable
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           MyTable.Load(MyReader);
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       public static void Select_HasOneParameter(string Query_Select, DataTable MyTable, string ParameterName, string ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
            MyCommand.Parameters.Add(ParameterName, OleDbType.VarChar).Value = ParameterValue;
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataTable
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           MyTable.Load(MyReader);
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       #endregion
       #region "SELECT dữ liệu đổ vào DataGridView"
       public static void Select_HasNoParameter(string Query_Select, DataGridView MyDataGridView)
       {

           //Tạo kết nối tới file Access
           CreateConnect();
           //Tạo đối tượng OledDBCommand
           OleDbCommand MyCommand = new OleDbCommand();
           //Gán tham số cho đối tượng OledDBCommand để thực hiện truy vấn dữ liệu từ CSDL            
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           MyCommand.Connection = MyConnect;
           //Tạo DataReader
           OleDbDataReader MyDataReader;
           //Cho DataReader nhận dữ liệu trả về của câu lệnh SQL vừa truy vấn
           MyDataReader = MyCommand.ExecuteReader();
           //Load DataReader vào DataTable
           DataTable MyTable = new DataTable();
           MyTable.Load(MyDataReader);
           MyDataGridView.DataSource = MyTable;
           //Dùng xong thì hủy các đối tượng
           //Hủy đối tượng OleDBCommand
           MyCommand.Dispose();
           MyCommand = null;
           //Hủy đối tượng DataReader (phải close trước khi hủy)
           MyDataReader.Close();
           MyDataReader.Dispose();
           MyDataReader = null;
           //Hủy kết nối với CSDL
           DestroyConnect();
       }
       public static void Select_HasManyParameter(string Query_Select, DataGridView MyDataGridView, string[] ParameterName, string[] ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
           for (int i = 0; i < ParameterName.Length; i++)
           {
               MyCommand.Parameters.Add(ParameterName[i], OleDbType.VarChar).Value = ParameterValue[i];
           }
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataGridView
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           DataTable MyTable = new DataTable();
           MyTable.Load(MyReader);
           MyDataGridView.DataSource = MyTable;
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       public static void Select_HasOneParameter(string Query_Select, DataGridView MyDataGridView, string ParameterName, string ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
           MyCommand.Parameters.Add(ParameterName, OleDbType.VarChar).Value = ParameterValue;
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataTable
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           DataTable MyTable = new DataTable();
           MyTable.Load(MyReader);
           MyDataGridView.DataSource = MyTable;
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       public static void Select_HasOneParameter(string Query_Select, BindingSource MyBindSource, string ParameterName, string ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
           MyCommand.Parameters.Add(ParameterName, OleDbType.VarChar).Value = ParameterValue;
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataTable
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           DataTable MyTable = new DataTable();
           MyTable.Load(MyReader);
           MyBindSource.DataSource = MyTable;
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       #endregion
       #region "SELECT dữ liệu đổ vào Combobox"
       public static void Select_HasNoParameter(string Query_Select,ComboBox MyCombobox,string MyField)
       {
           //Tạo kết nối tới file Access
           CreateConnect();
           //Tạo đối tượng OledDBCommand
           OleDbCommand MyCommand = new OleDbCommand();
           //Gán tham số cho đối tượng OledDBCommand để thực hiện truy vấn dữ liệu từ CSDL            
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           MyCommand.Connection = MyConnect;
           //Tạo DataReader
           OleDbDataReader MyDataReader;
           //Cho DataReader nhận dữ liệu trả về của câu lệnh SQL vừa truy vấn
           MyDataReader = MyCommand.ExecuteReader();
           //Load DataReader vào DataTable
           DataTable MyTable = new DataTable();
           MyTable.Load(MyDataReader);
           //Fill dữ liệu từ DataTable vào Combobox ứng với trường MyField
           MyCombobox.DataSource = MyTable;
           MyCombobox.DisplayMember = MyField;
           //Dùng xong thì hủy các đối tượng
                //Hủy đối tượng OleDBCommand
           MyCommand.Dispose();
           MyCommand = null;
                //Hủy đối tượng DataReader (phải close trước khi hủy)
           MyDataReader.Close();
           MyDataReader.Dispose();
           MyDataReader = null;
                //Hủy kết nối với CSDL
           DestroyConnect();
       }
       public static void Select_HasManyParameter(string Query_Select, ComboBox MyCombobox, string MyField, string[] ParameterName, string[] ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
           for (int i = 0; i < ParameterName.Length; i++)
           {
               MyCommand.Parameters.Add(ParameterName[i], OleDbType.VarChar).Value = ParameterValue[i];
           }
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataTable
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           DataTable MyTable = new DataTable();
           MyTable.Load(MyReader);
           //5.Fill dữ liệu từ DataTable vào Combobox ứng với trường MyField
           MyCombobox.DataSource = MyTable;
           MyCombobox.SelectedIndex = 0;
           MyCombobox.DisplayMember = MyField;
           //6.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       public static void Select_HasOneParameter(string Query_Select, ComboBox MyCombobox, string MyField, string ParameterName, string ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Select;
           //3.Thêm tham số cho câu lệnh Query
           MyCommand.Parameters.Add(ParameterName, OleDbType.VarChar).Value = ParameterValue;
           //4.Thực hiện câu lệnh query và đổ dữ liệu vào DataTable
           OleDbDataReader MyReader = MyCommand.ExecuteReader();
           DataTable MyTable = new DataTable();
           MyTable.Load(MyReader);
           //5.Fill dữ liệu từ DataTable vào Combobox ứng với trường MyField
           MyCombobox.DataSource = MyTable;
           try
           {
               MyCombobox.SelectedIndex = 0;
           }
           catch (Exception e)
           {
               e.Message.ToString();
           }
           
           MyCombobox.DisplayMember = MyField;
           //6.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       #endregion
       #region "Update dữ liệu trong DataTable"
       public static void Update_HasNoParameter(string Query_Update)
       {
           //Tạo kết nối tới file Access
           CreateConnect();
           //Tạo đối tượng Command
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Update;
           //Ra lệnh cho MyCommand thực hiện Query trực tiếp trong CSDL
           MyCommand.ExecuteNonQuery();
           //Dùng xong thì hủy các đối tượng
           MyCommand.Connection = null;
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       public static void Update_HasManyParameter(string Query_Update, string[] ParameterName, string[] ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Update;
           //3.Thêm tham số cho câu lệnh Query
           for (int i = 0; i < ParameterName.Length; i++)
           {
               MyCommand.Parameters.Add(ParameterName[i], OleDbType.VarChar).Value = ParameterValue[i];
           }
           //4.Thực hiện câu lệnh query
           MyCommand.ExecuteNonQuery();
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       public static void Update_HasOneParameter(string Query_Update, string ParameterName, string ParameterValue)
       {
           //1.Khởi tạo kết nối với file Access
           CreateConnect();
           //2.Thiết lập đối tượng OleDbCommand
           OleDbCommand MyCommand = new OleDbCommand();
           MyCommand.Connection = MyConnect;
           MyCommand.CommandType = CommandType.StoredProcedure;
           MyCommand.CommandText = Query_Update;
           //3.Thêm tham số cho câu lệnh Query
            MyCommand.Parameters.Add(ParameterName, OleDbType.VarChar).Value = ParameterValue;
           //4.Thực hiện câu lệnh query
           MyCommand.ExecuteNonQuery();
           //5.Dùng xong thì hủy các đối tượng không cần thiết
           MyCommand.Parameters.Clear();
           MyCommand.Dispose();
           MyCommand = null;
           DestroyConnect();
       }
       #endregion
       #region "Sinh mã số hóa đơn"
       public static string Sinh_MS(string Query_Select_Last, string header, int max_length) //Tự động load mã số tăng dần, mã số có số chữ số là max_length 
       {
           //1.Select mã số mới nhất trong CSDL
           DataTable Table_MS = new DataTable();
           DatabaseAccess.Select_HasNoParameter(Query_Select_Last, Table_MS);
           string MS = Table_MS.Rows[0][0].ToString();
           //2.Xử lý chuỗi nhận được
           //2.1.Tăng mã số lên 1
           int MS_int = Convert.ToInt32(MS.Remove(0, header.Length)) + 1;
           //2.2.Ghép các chữ số 0 vào trước mã số nếu số chữ số < max_length
           string x = ""; //x là xâu các số 0, vd MS007 thì x là 00
           int k = MS_int.ToString().Length; //k là độ dài xâu mã số
           if (k < max_length)
           {
               for (int i = 0; i < max_length - k; i++)
               {
                   x = x + "0";
               }
           }
           return (header + x + MS_int.ToString());
       }
       #endregion
       #region "Những hàm load mã số từ giá trị user đã chọn"
       public static string Select_Quan(string TenQuan) //Load mã quận từ CSDL lên ứng với tên quận đã chọn
       {
           DataTable MyTable = new DataTable();
           DatabaseAccess.Select_HasOneParameter("SELECT_DM_Quan", MyTable, "@TenQuan", TenQuan);
           return (MyTable.Rows[0][0].ToString());
       }
       #endregion
       #region "Những hàm hỗ trợ bắt lỗi input"
       public static void AllowDigit(KeyPressEventArgs e)
       {
           //Chỉ cho phép nhập vào kí tự số,kí tự ".",các mũi tên điều khiển (để user đánh lại khi sai)
           if ((Char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '.') && (e.KeyChar != ',') && (Char.IsControl(e.KeyChar) == false))
           {
               e.Handled = true;
           }
       }
       public static Boolean CheckDigit(string mystring)
       {
           char[] kt ={ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
           Boolean ketqua = true;
           int j = 0;
           for (int i = 0; i < mystring.Length; i++)
           {
               while (j <= 10)
               {
                   if (mystring[i] == kt[j])
                   {

                       j = 0;
                       break;
                   }
                   else
                   {
                       j += 1;
                       if (j == 11)
                       {
                           ketqua = false;
                           i = mystring.Length;
                           break;
                       }
                   }
               }

           }
           return (ketqua);
       }
       #endregion
       #region "Đổ dữ liệu từ DataTable lên combobox"
       public static void fillDatatableToCombobox(DataTable MyTable,ComboBox MyCombobox,string MyField)
       {
           MyCombobox.DataSource = MyTable;
           MyCombobox.SelectedIndex = 0;
           MyCombobox.DisplayMember = MyField;
       }
       #endregion
       public static void DanhSttDataGridView(DataGridView dgv)
       {
           int STT = 1;
           foreach (DataGridViewRow MyRow in dgv.Rows)
           {
               MyRow.Cells["STT"].Value = STT.ToString();
               STT++;
           }
       }

       public static void ToMauChanLeDatagridView(DataGridView MyDataGridView)
       {
           for (int i = 0; i < MyDataGridView.RowCount; i++)
           {
               if (i % 2 == 1)
               {
                   MyDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
               }
           }
       }
   }
}
