using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerManagementApp
{
    public class MessageClass
    {
        public static void MSError1() {
            MessageBox.Show("ID又はパスワードが間違っています！", "エラーメッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MSError2(SqlException ex)
        {
            // SQLサーバーへの接続時にエラーが発生した場合、それをキャッチして処理する
            MessageBox.Show("SQLサーバーへの接続時にエラーが発生しました！\n" + ex.Message, "エラーメッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MSError3()
        {
            // SQLサーバーへの接続時にエラーが発生した場合、それをキャッチして処理する
            MessageBox.Show("選択された項目がありません！", "エラーメッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
