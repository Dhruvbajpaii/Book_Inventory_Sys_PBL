namespace BIS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = Box1.Height;
            SidePanel.Top = Box1.Top;
            issue1.BringToFront();


        }

       

        private void esc(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void book1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Box1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Box1.Height;
            SidePanel.Top = Box1.Top;
            issue1.BringToFront();



        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Box2.Height;
            SidePanel.Top = Box2.Top;
            addbook1.BringToFront();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Box3.Height;
            SidePanel.Top = Box3.Top;
            adduser1.BringToFront();
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Box4.Height;
            SidePanel.Top = Box4.Top;
            listbook1.BringToFront();
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Box5.Height;
            SidePanel.Top = Box5.Top;
            listuser1.BringToFront();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search1.BringToFront();
        }
    }
}