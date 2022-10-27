# 第2次作業-作業-HW2
>
>學號：109111104 
><br />
>姓名：李彥賓
><br />
>作業撰寫時間：50 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/10/28
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

namespace _111_1HW2
{
    public partial class Bomb : System.Web.UI.Page
    {
        public partial class Bomb : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                string[,] ia_Map = new string[10, 10];
                int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };

                for (int Q = 0; Q < ia_MIndex.Length; Q++)
                {
                    int X = ia_MIndex[Q] / ia_MIndex.Length;
                    int Y = ia_MIndex[Q] % ia_MIndex.Length;
                    ia_Map[X, Y] = "*";

                }
                for (int R = 0; R < ia_Map.GetLength(0); R++)
                {
                    for (int E = 1; E < ia_Map.GetLength(1); E++)
                    {
                        if (ia_Map[R, E] != "*") ia_Map[R, E] = "?";
                        Response.Write(ia_Map[R, E] + "  ");
                    }
                    Response.Write("<br>");
                }
            }
        }
    }

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bomb.aspx.cs" Inherits="_111_1QZ1.Bomb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

先設好二維陣列及一維陣列，儲存Bomb的位置到對應的二維陣列

