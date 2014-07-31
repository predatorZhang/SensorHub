using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperSocket.Common;
using SuperSocket.SocketBase.Protocol;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            IList<byte> source = new List<byte>();
            source.Add(12);
            source.Add(78);
            */
            /*
            source.Add(89);
            source.Add(11);
            source.Add(16);
            source.Add(13);
            source.Add(13);
            source.Add(16);
         */
  

            byte[] target = {0x7D,0x01,0x00,0x16};
           string sss = BitConverter.ToString(target);
           if (sss == "7D-01-00-16")
           {
               int A = 0;
           }
         /*
            string ss0=  Convert.ToBase64String(target);
            Convert.
            string ss = Encoding.UTF8.GetString(target);
         */
           // byte[] source = {11,12,3,14,5,7,8,6,16,78,32,21,4,79,16,78,8,11,12,45,56,76,16,78};
            
           // int rest;
           // TerminatorReceiveFilter filter = new TerminatorReceiveFilter(target,Encoding.ASCII);
     
            //filter.Filter(source,9,10,true, out rest);
           // IRequestInfo iRequestInfo = (IRequestInfo)filter.Filter(source, 0, source.Count, true,rest);


            
        //   int ss = BinaryUtil.IndexOf(source, target[0], 0, source.Count);

           //int ss8 =(int)BinaryUtil.SearchMark<byte>(source, 0, source.Count, target, 0);
   //         int ss9 = BinaryUtil.StartsWith<byte>(source, 0, source.Count, target);
        
        //  int ss0 = (int) BinaryUtil.SearchMark<byte>(source,0,source.Count,target,0);

        }
    }
}
