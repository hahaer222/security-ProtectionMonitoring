using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OuterCavity.InfoSearch
{
    public partial class frmDeliver : OuterCavity.frmBase
    {
        string sql = "select * from (";
        string sql1 = "(select a.P_Key,a.Name, Take_Type type,Police_Name,Take_Time from Prisoner_Take a left join Prisoner b on a.P_Key=b.P_Key and a.Name=b.Name) union ";
        string sql2 = "(selecta.P_Key,a.Name,  Interrogation_Type type,Police_Name,Interrogation_Time Take_Time from Prisoner_Interrogation a left join Prisoner b on a.P_Key=b.P_Key and a.Name=b.Name) union ";
        string sql3 = "(select a.P_Key,a.Name, '倒监' type,Police_Name,Out_Time Take_Time from Prisoner_Swap a left join Prisoner b on a.P_Key=b.P_Key and a.Name=b.Name) ";
        string sqlend = ") t where t.P_Key='" + PersonInfo.PersonCode + "' and t.Name='" + PersonInfo .PersonName+ "'";
        
        public frmDeliver()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(PersonInfo.PersonCode) && !string.IsNullOrEmpty(PersonInfo.PersonName))
            { 
            
            }

        }
    }
}
