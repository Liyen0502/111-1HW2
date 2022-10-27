using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
