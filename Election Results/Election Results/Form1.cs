using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Election_Results
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private int precinct = 0;
        private string mayor = "";
        private string council = "";
        private int oneMClark = 0;
        private int twoMClark = 0;
        private int threeMClark = 0;
        private int oneMAbernathy = 0;
        private int twoMAbernathy = 0;
        private int threeMAbernathy = 0;
        private int oneCDouglas = 0;
        private int oneCThompson = 0;
        private int oneCWilliams = 0;
        private int twoCBaker = 0;
        private int twoCStevenson = 0;
        private int threeCDavis = 0;
        private int threeCWilliams = 0;
        private int threeCZiegler = 0;
        private int totalMClark = 0;
        private int totalMAbernathy = 0;
        private int totalVotes = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog results = new OpenFileDialog();
            //results.FileName = "election_data_2012.txt";
            if (results.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader(results.FileName);
                do
                {
                    list.Add(sr.ReadLine());
                    precinct = int.Parse(list[list.Count - 1].Substring(0, 1).Trim());
                    mayor = list[list.Count - 1].Substring(2, 15).Trim();
                    council = list[list.Count - 1].Substring(17, 15).Trim();
                    if (precinct == 1)
                    {
                        if (mayor.Equals("Clark"))
                        {
                            oneMClark++;
                            totalMClark++;
                            totalVotes++;
                        }
                        else if (mayor.Equals("Abernathy"))
                        {
                            oneMAbernathy++;
                            totalMAbernathy++;
                            totalVotes++;
                        }
                        if (council.Equals("Douglas"))
                        {
                            oneCDouglas++;
                        }
                        else if (council.Equals("Thompson"))
                        {
                            oneCThompson++;
                        }
                        else if (council.Equals("Williams"))
                        {
                            oneCWilliams++;
                        }
                    }
                    else if (precinct == 2)
                    {
                        if (mayor.Equals("Clark"))
                        {
                            twoMClark++;
                            totalMClark++;
                            totalVotes++;
                        }
                        else if (mayor.Equals("Abernathy"))
                        {
                            twoMAbernathy++;
                            totalMAbernathy++;
                            totalVotes++;
                        }
                        if (council.Equals("Baker"))
                        {
                            twoCBaker++;
                        }
                        else if (council.Equals("Stevenson"))
                        {
                            twoCStevenson++;
                        }
                    }
                    else if (precinct == 3)
                    {
                        if (mayor.Equals("Clark"))
                        {
                            threeMClark++;
                            totalMClark++;
                            totalVotes++;
                        }
                        else if (mayor.Equals("Abernathy"))
                        {
                            threeMAbernathy++;
                            totalMAbernathy++;
                            totalVotes++;
                        }
                        if (council.Equals("Davis"))
                        {
                            threeCDavis++;
                        }
                        else if (council.Equals("Williams"))
                        {
                            threeCWilliams++;
                        }
                        else if (council.Equals("Ziegler"))
                        {
                            threeCZiegler++;
                        }

                    }
                } while (!sr.EndOfStream);
                sr.Close();

                textTotalVotes.Text = totalVotes.ToString();

                textOneMClark.Text = oneMClark.ToString();
                textOneMAbernathy.Text = oneMAbernathy.ToString();

                textTwoMClark.Text = twoMClark.ToString();
                textTwoMAbernathy.Text = twoMAbernathy.ToString();

                textThreeMClark.Text = threeMClark.ToString();
                textThreeMAbernathy.Text = threeMAbernathy.ToString();

                textTotalMClark.Text = totalMClark.ToString();
                textTotalMAbernathy.Text = totalMAbernathy.ToString();

                textOneCDouglas.Text = oneCDouglas.ToString();
                textOneCThompson.Text = oneCThompson.ToString();
                textOneCWilliams.Text = oneCWilliams.ToString();

                textTwoCBaker.Text = twoCBaker.ToString();
                textTwoCStevenson.Text = twoCStevenson.ToString();

                textThreeCDavis.Text = threeCDavis.ToString();
                textThreeCWilliams.Text = threeCWilliams.ToString();
                textThreeCZiegler.Text = threeCZiegler.ToString();

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
