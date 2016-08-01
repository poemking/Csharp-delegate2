using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProj_delegate2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 定義一個自訂借錢動作的委派(想像成是定義一個介面，規定參數及回傳型態就對了)
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        delegate string CustomAction(string amount);

        CustomAction customAction;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirl_Click(object sender, EventArgs e)
        {
            customAction = LendToGirl;
            LendAction("30萬", customAction);
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            customAction = LendToFriend;
            LendAction("100", customAction);
        }

        private void btnLoser_Click(object sender, EventArgs e)
        {
            customAction = LendToLoser;
            LendAction("10", customAction);
        }

        /// <summary>
        /// 借錢動作
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="customAct"></param>
        private void LendAction(string amount, CustomAction customAct)
        {
            txtResult.Text = string.Empty;

            //決定要借出的金額
            string finalAmount;

            //我們不需要知道這個customAct到底是什麼
            //反正他跑完會回傳一個我們要的東西就對了
            //在這裡回傳的就是最終借出金額
            finalAmount = customAct(amount); //這行會跳進去+入的委派function

            string commonRes;
            if (!string.IsNullOrEmpty(finalAmount))
            {
                commonRes = string.Format("借出{0}元", finalAmount);
            }
            else
            {
                commonRes = "掉頭就走";
            }

            txtResult.Text += commonRes;
        }

        /// <summary>
        /// 借錢給正妹的自訂動作
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private string LendToGirl(string amount)
        {
            //自訂動作：跟正妹狂聊，最後決定借五百萬
            var res =
    @"詢問正妹：真的只要借{0}嗎?夠不夠啊?
詢問正妹：要幫妳買點數卡嗎?
詢問正妹：可以加妳的Line嗎?
詢問正妹：妳幾歲呀?
詢問正妹：妳住哪?
詢問正妹：妳有男朋友嗎?
詢問正妹：妳三圍多少?
詢問正妹：禮拜六有空嗎?
...
.....
....
哇!服務這麼好喔!
....
.....
GGInInDer
OK~{1}沒問題!
....
...去提款機領{1}元
";
            var finalAmount = "五百萬";
            txtResult.Text = string.Format(res, amount, finalAmount);

            //回傳最後決定的金額
            return finalAmount;
        }

        private string LendToFriend(string amount) 
        {
            var res = @"幹...
            (錢包掉出{0}元)";

            txtResult.Text = string.Format(res, amount);
            return amount;
        }

        private string LendToLoser(string amount) 
        {
            return string.Empty;
        }
    }
}
