using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.mariuszgromada.math.mxparser;
using ParticleSwarmOptimization.Forms;

namespace ParticleSwarmOptimization
{
    public partial class View2D : Form, IObserver
    {
        PSOModel model;
        Controller2D controller;
        Function f;
        public View2D(PSOModel model)
        {
            InitializeComponent();
            this.model = model;
            this.model.Register(this);

            AddController(MakeConrtoller());

            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart.ChartAreas[0].AxisX.Minimum = (int)numericUpDownOXmin.Value;
            chart.ChartAreas[0].AxisY.Minimum = (int)numericUpDownOYmin.Value;
            chart.ChartAreas[0].AxisX.Maximum = (int)numericUpDownOXmax.Value;
            chart.ChartAreas[0].AxisY.Maximum = (int)numericUpDownOYmax.Value;

            chart.Series.Add("function");
            chart.Series[0].ChartType = SeriesChartType.Spline;

            chart.Series.Add("points");
            chart.Series[1].Color = Color.Black;
            chart.Series[1].ChartType = SeriesChartType.Point;

            f = new Function("f(x) = " + functionBox.Text);

            DrawFunction();
        }

        public void DrawFunction()
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            for (double X = chart.ChartAreas[0].AxisX.Minimum; X <= chart.ChartAreas[0].AxisX.Maximum; X += 0.1)
            {
                chart.Series[0].Points.AddXY(X, f.calculate(X));
            }
        }
        public void UpdateState()
        {
            double[] x = model.GetPoints();

            chart.Series[1].Points.Clear();

            for (int i = 0; i < (int)RoyТumericUpDown.Value; i += 1)
            {
                chart.Series[1].Points.AddXY(x[i], model.GetFunction().calculate(x[i]));
            }
        }

        public Controller2D MakeConrtoller()
        {
            return new Controller2D(this, this.model);
        }
        public void AddController(Controller2D controller)
        {
            this.controller = controller;
        }

        //------------------------------------------------------------------------
        private void SS_button_Click(object sender, EventArgs e)
        {
                controller.StartStop();
        }

        private void numericUpDownOXmin_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Minimum = (int)numericUpDownOXmin.Value;
            DrawFunction();
        }
        private void numericUpDownOXmax_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Maximum = (int)numericUpDownOXmax.Value;
            DrawFunction();
        }
        private void numericUpDownOYmin_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Minimum = (int)numericUpDownOYmin.Value;
        }
        private void numericUpDownOYmax_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Maximum = (int)numericUpDownOYmax.Value;
        }

        private void ParamButton_Click(object sender, EventArgs e)
        {
            controller.SetParam(functionBox.Text, (int)RoyТumericUpDown.Value, chart.ChartAreas[0].AxisX.Minimum, chart.ChartAreas[0].AxisX.Maximum);
            UpdateState();
            AnswerLable.Text = $"Точка минимума:";
        }

        private void RoyТumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            controller.SetParam(functionBox.Text, (int)RoyТumericUpDown.Value, chart.ChartAreas[0].AxisX.Minimum, chart.ChartAreas[0].AxisX.Maximum);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
            infoForm.Dispose();
        }

        private void algoritmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlgForm algForm = new AlgForm();
            algForm.ShowDialog();
            algForm.Dispose();
        }

        private void DrawFButton_Click(object sender, EventArgs e)
        {
            f = new Function("f(x) = " + functionBox.Text);
            if (!f.checkSyntax())
            {
                MessageBox.Show("Введите функцию f(x) правильно!!!", "Error");
            }
            else
            {
                DrawFunction();
            }
        }

        public void Answer(double g)
        {
            AnswerLable.Text = $"Точка минимума: ({Math.Round(g, 3)}, {Math.Round(model.GetFunction().calculate(g), 3)})";
        }

        private void GraficColor_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            colorDialog.Color = chart.Series[0].Color;
            colorDialog.ShowDialog();
            chart.Series[0].Color = colorDialog.Color;
        }

        private void PointsColor_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            colorDialog.Color = chart.Series[1].Color;
            colorDialog.ShowDialog();
            chart.Series[1].Color = colorDialog.Color;
        }

        private void aboutDeveloper_Click(object sender, EventArgs e)
        {
            DeveloperForm developerForm = new DeveloperForm();
            developerForm.ShowDialog();
            developerForm.Dispose();
        }
    }
}

