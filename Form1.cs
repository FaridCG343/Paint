namespace Paint
{
    public partial class frmcgfPaint : Form
    {
        Color color = Color.Black, colorAnt;
        bool isDrawing = false;
        int grosor = 4;
        public frmcgfPaint()
        {
            InitializeComponent();
        }

        public void btnColor_Click(object sender, EventArgs e)
        {
            Button btnColor = (Button)sender;
            this.color = btnColor.BackColor;
            btncgfColorActual.BackColor = btnColor.BackColor;
        }

        private void btncgfColorDialog_Click(object sender, EventArgs e)
        {
            colorDialogcgf.ShowDialog();
            color = colorDialogcgf.Color;
            btncgfColorActual.BackColor = color;
        }

        private void btncgfClear_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
        }

        private void frmcgfPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = e.Y > pnlcgfPanel.Height;
        }

        private void frmcgfPaint_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void frmcgfPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(new SolidBrush(color), e.X, e.Y, grosor, grosor);
            }
        }

        private void btncgfBorrador_Click(object sender, EventArgs e)
        {
            color = Color.White;
        }

        private void tcbcgfGrosorLapiz_Scroll(object sender, EventArgs e)
        {
            grosor = tcbcgfGrosorLapiz.Value;
            lblcgfGrosor.Text = "Grosor: " + grosor.ToString();
        }

        private void btncgfLapiz_Click(object sender, EventArgs e)
        {
            color = btncgfColorActual.BackColor;
        }
    }
}