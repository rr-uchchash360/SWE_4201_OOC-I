using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class BankManagementSystem : Form
    {
        double accountNo = 1;

        List<Current> CurrentAccs = new List<Current>();
        List<Savings> savingsAccs = new List<Savings>();
        List<Loan> loanAccs = new List<Loan>();


        public BankManagementSystem()
        {
            InitializeComponent();
        }

        private void createAccountOnClick_Click(object sender, EventArgs e)
        {


            if (currentButton1.Checked)
            {
                string account = Convert.ToString(accountNo) + "300";
                ++accountNo;
                double ammount = Convert.ToDouble(balanceBox.Text);

                Current dummy = new Current();

                dummy.accountNo = account;
                dummy.ammount = ammount;
                CurrentAccs.Add(dummy);
                MessageBox.Show("Account has been created!\n" + "Account No. :" + account);

            }
            else if (savingsButton2.Checked)
            {
                double balance = Convert.ToDouble(balanceBox.Text);

                if (balance < 50000)
                {
                    MessageBox.Show("Insufficient Balance!");
                }
                else
                {
                    string account = Convert.ToString(accountNo) + "314";
                    ++accountNo;
                    double ammount = Convert.ToDouble(balanceBox.Text);

                    Savings dummy = new Savings();

                    dummy.accountNo = account;
                    dummy.ammount = ammount;
                    savingsAccs.Add(dummy);
                    MessageBox.Show("Account has been created!\n" + "Account No. :" + account);
                }

            }
            else if (loanButton3.Checked)
            {
                string account = Convert.ToString(accountNo) + "400";
                ++accountNo;
                double ammount = Convert.ToDouble(balanceBox.Text);// + (Convert.ToDouble(balanceBox.Text) * (9 / 100));
                ammount = ammount + (ammount * 0.09);
                Loan dummy = new Loan();

                dummy.accountNo = account;

                dummy.interest(ammount);

                dummy.ammount = ammount;

                loanAccs.Add(dummy);
                MessageBox.Show("Account has been created!\n" + "Account No. :" + account);
            }
            else
            {
                MessageBox.Show("Check Given Informations!");
            }

        }

        private void depositOnClick(object sender, EventArgs e)
        {
            string accountNo = IDboxDep.Text;
            double ammount = Convert.ToDouble(amountBoxDep.Text);
            if (ammount < 0)
            {
                throw new ApplicationException("NegativeInputException");
            }
            bool errorExists = true;

            for (int i = 0; i < CurrentAccs.Count; i++)
            {
                if (accountNo == CurrentAccs[i].accountNo)
                {
                    errorExists = false;
                    if (ammount > 100000)
                    {
                        MessageBox.Show("Ammount limit exceeded!");
                    }
                    else
                    {
                        Transactions dumb = new Transactions();
                        dumb.type = "Deposit";
                        dumb.amount = ammount;

                        CurrentAccs[i].transactionsList.Add(dumb);


                        CurrentAccs[i].ammount += ammount;

                        MessageBox.Show("Ammount has been deposited");
                    }

                    break;
                }
            }
            for (int i = 0; i < savingsAccs.Count; i++)
            {
                if (accountNo == savingsAccs[i].accountNo)
                {
                    errorExists = false;

                    if (savingsAccs[i].checkLimit() == true)
                    {
                        Transactions dumb = new Transactions();
                        dumb.type = "Deposit";
                        dumb.amount = ammount;
                        savingsAccs[i].transactionsList.Add(dumb);

                        savingsAccs[i].ammount += ammount;
                        --savingsAccs[i].transLimit;

                        MessageBox.Show("Ammount has been deposited");
                    }
                    else
                    {
                        MessageBox.Show("Maximum Transactions (5) have been exceeded");
                    }

                    break;
                }
            }
            for (int i = 0; i < loanAccs.Count; i++)
            {
                if (accountNo == loanAccs[i].accountNo)
                {
                    errorExists = false;

                    if (ammount > loanAccs[i].ammount)
                    {
                        MessageBox.Show("Ammount exceeds due ammount!");
                    }
                    else if (ammount == 0)
                    {
                        MessageBox.Show("No more transactions can be made");
                    }
                    else
                    {
                        Transactions dumb = new Transactions();
                        dumb.type = "Deposit";
                        dumb.amount = ammount;
                        loanAccs[i].transactionsList.Add(dumb);

                        loanAccs[i].ammount -= ammount;
                    }

                    MessageBox.Show("Ammount has been deposited");

                    break;
                }
            }

            if (errorExists)
            {
                MessageBox.Show("Account Does Not Exist");
            }
        }

        private void withOnClick(object sender, EventArgs e)
        {
            string accountNo = idBoxWith.Text;
            double ammount = Convert.ToDouble(amountBoxWith.Text);
            if (ammount < 0)
            {
                throw new ApplicationException("NegativeInputException");
            }
            bool errorExists = true;

            for (int i = 0; i < CurrentAccs.Count; i++)
            {
                if (accountNo == CurrentAccs[i].accountNo)
                {
                    errorExists = false;
                    if (ammount > 100000)
                    {
                        MessageBox.Show("Ammount Exceeds Transaction Limit");
                    }
                    else
                    {
                        if (ammount < CurrentAccs[i].ammount)
                        {
                            Transactions dumb = new Transactions();
                            dumb.type = "Withdraw";
                            dumb.amount = ammount;
                            CurrentAccs[i].transactionsList.Add(dumb);

                            CurrentAccs[i].ammount -= ammount;

                            MessageBox.Show("Ammount has been withdrawn");

                        }
                        else
                        {
                            MessageBox.Show("Amount Exceeds balance!");

                        }
                    }
                    break;
                }
            }
            for (int i = 0; i < savingsAccs.Count; i++)
            {
                if (accountNo == savingsAccs[i].accountNo)
                {
                    errorExists = false;

                    if (savingsAccs[i].checkLimit() == true)
                    {

                        if (ammount < savingsAccs[i].ammount)
                        {
                            Transactions dumb = new Transactions();
                            dumb.type = "Withdraw";
                            dumb.amount = ammount;
                            savingsAccs[i].transactionsList.Add(dumb);

                            savingsAccs[i].ammount -= ammount;
                            savingsAccs[i].ammount -= 15;
                            --savingsAccs[i].transLimit;

                            MessageBox.Show("Ammount has been withdrawn");

                        }
                        else
                        {
                            MessageBox.Show("Amount Exceeds balance!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Maximum Transactions (5) have been exceeded");

                    }
                    break;
                }
            }
            for (int i = 0; i < loanAccs.Count; i++)
            {
                if (accountNo == loanAccs[i].accountNo)
                {
                    errorExists = false;

                    MessageBox.Show("Can not withdraw from a Loan account");

                    break;
                }
            }



            if (errorExists)
            {
                MessageBox.Show("Account Does Not Exist");
            }
        }

        private void showOn_Click(object sender, EventArgs e)
        {
            string accountNo = idBoxAccInf.Text;


            bool errorExists = true;

            for (int i = 0; i < CurrentAccs.Count; i++)
            {
                if (accountNo == CurrentAccs[i].accountNo)
                {
                    errorExists = false;
                    listBox1.Items.Clear();

                    string get = "Current Account  " + CurrentAccs[i].accountNo + "  " + CurrentAccs[i].ammount.ToString();
                    listBox1.Items.Add(get);

                    break;
                }
            }
            for (int i = 0; i < savingsAccs.Count; i++)
            {
                if (accountNo == savingsAccs[i].accountNo)
                {
                    errorExists = false;
                    listBox1.Items.Clear();

                    string get = "Savings Account  " + savingsAccs[i].accountNo + "  " + savingsAccs[i].ammount.ToString();
                    listBox1.Items.Add(get);

                    break;
                }
            }
            for (int i = 0; i < loanAccs.Count; i++)
            {
                if (accountNo == loanAccs[i].accountNo)
                {
                    errorExists = false;
                    listBox1.Items.Clear();

                    string get = "Loan Account  " + loanAccs[i].accountNo + "  " + loanAccs[i].ammount.ToString();
                    listBox1.Items.Add(get);

                    break;
                }
            }
            if (errorExists)
            {
                MessageBox.Show("Account Does Not Exist");
            }
        }

        private void showOnclkTrans_Click(object sender, EventArgs e)
        {
            string accountNo = idBoxTransInfo.Text;
            bool errorExists = true;

            for (int i = 0; i < CurrentAccs.Count; i++)
            {
                if (accountNo == CurrentAccs[i].accountNo)
                {
                    errorExists = false;
                    listBox2.Items.Clear();

                    for (int j = 0; j < CurrentAccs[i].transactionsList.Count; j++)
                    {
                        listBox2.Items.Add(CurrentAccs[i].transactionsList[j].getter());
                    }
                    break;
                }
            }
            for (int i = 0; i < savingsAccs.Count; i++)
            {
                if (accountNo == savingsAccs[i].accountNo)
                {
                    errorExists = false;
                    listBox2.Items.Clear();

                    for (int j = 0; j < savingsAccs[i].transactionsList.Count; j++)
                    {
                        listBox2.Items.Add(savingsAccs[i].transactionsList[j].getter());
                    }
                    break;
                }
            }
            for (int i = 0; i < loanAccs.Count; i++)
            {
                if (accountNo == loanAccs[i].accountNo)
                {
                    errorExists = false;
                    listBox2.Items.Clear();

                    for (int j = 0; j < loanAccs[i].transactionsList.Count; j++)
                    {
                        listBox2.Items.Add(loanAccs[i].transactionsList[j].getter());
                    }
                    break;
                }
            }
            if (errorExists)
            {
                MessageBox.Show("Account Does Not Exist");
            }
        }
    }
}
