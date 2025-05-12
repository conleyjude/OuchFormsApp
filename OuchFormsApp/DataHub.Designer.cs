namespace OuchFormsApp
{
    partial class DataHub
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            rightPanel = new Panel();
            currentPainLabel = new Label();
            currentPainBox = new TextBox();
            label2 = new Label();
            thresholdUpDown = new NumericUpDown();
            painChangeLabel = new Label();
            painChangeText = new TextBox();
            messageLabel = new Label();
            availableMessageText = new TextBox();
            painChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            leftPanel = new Panel();
            patientLabel = new Label();
            patientsBox = new ComboBox();
            mainPanel = new Panel();
            graphPanel = new Panel();
            graphLabel = new Label();
            refreshTimer = new System.Windows.Forms.Timer(components);
            bindingSource1 = new BindingSource(components);
            painReqTimer = new System.Windows.Forms.Timer(components);
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thresholdUpDown).BeginInit();
            leftPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            graphPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 26.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(2384, 106);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "O.U.C.H. Data Hub";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // rightPanel
            // 
            rightPanel.AutoSize = true;
            rightPanel.BackColor = Color.MediumPurple;
            rightPanel.Controls.Add(currentPainLabel);
            rightPanel.Controls.Add(currentPainBox);
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(thresholdUpDown);
            rightPanel.Controls.Add(painChangeLabel);
            rightPanel.Controls.Add(painChangeText);
            rightPanel.Controls.Add(messageLabel);
            rightPanel.Controls.Add(availableMessageText);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(2034, 0);
            rightPanel.Margin = new Padding(7, 3, 7, 3);
            rightPanel.MinimumSize = new Size(350, 1411);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(350, 1420);
            rightPanel.TabIndex = 9;
            // 
            // currentPainLabel
            // 
            currentPainLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            currentPainLabel.AutoSize = true;
            currentPainLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPainLabel.Location = new Point(60, 15);
            currentPainLabel.Margin = new Padding(5, 0, 5, 0);
            currentPainLabel.Name = "currentPainLabel";
            currentPainLabel.Size = new Size(253, 54);
            currentPainLabel.TabIndex = 14;
            currentPainLabel.Text = "Pain Reading";
            currentPainLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // currentPainBox
            // 
            currentPainBox.Anchor = AnchorStyles.Top;
            currentPainBox.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPainBox.Location = new Point(46, 83);
            currentPainBox.Name = "currentPainBox";
            currentPainBox.Size = new Size(267, 57);
            currentPainBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 498);
            label2.Name = "label2";
            label2.Size = new Size(333, 54);
            label2.TabIndex = 12;
            label2.Text = "Patient Threshold";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // thresholdUpDown
            // 
            thresholdUpDown.Anchor = AnchorStyles.Top;
            thresholdUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thresholdUpDown.Location = new Point(34, 555);
            thresholdUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            thresholdUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            thresholdUpDown.Name = "thresholdUpDown";
            thresholdUpDown.Size = new Size(300, 61);
            thresholdUpDown.TabIndex = 11;
            thresholdUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // painChangeLabel
            // 
            painChangeLabel.Anchor = AnchorStyles.Top;
            painChangeLabel.AutoSize = true;
            painChangeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            painChangeLabel.Location = new Point(38, 304);
            painChangeLabel.Name = "painChangeLabel";
            painChangeLabel.Size = new Size(288, 54);
            painChangeLabel.TabIndex = 6;
            painChangeLabel.Text = "Change in Pain";
            painChangeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // painChangeText
            // 
            painChangeText.Anchor = AnchorStyles.Top;
            painChangeText.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            painChangeText.Location = new Point(46, 361);
            painChangeText.Name = "painChangeText";
            painChangeText.Size = new Size(267, 57);
            painChangeText.TabIndex = 5;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(11, 158);
            messageLabel.Margin = new Padding(5, 0, 5, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(334, 54);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Last Pain Reading";
            messageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // availableMessageText
            // 
            availableMessageText.Anchor = AnchorStyles.Top;
            availableMessageText.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availableMessageText.Location = new Point(46, 226);
            availableMessageText.Name = "availableMessageText";
            availableMessageText.Size = new Size(267, 57);
            availableMessageText.TabIndex = 3;
            // 
            // painChart1
            // 
            painChart1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            painChart1.BackColor = SystemColors.Control;
            painChart1.Dock = DockStyle.Fill;
            painChart1.Font = new Font("Segoe UI", 9F);
            painChart1.Location = new Point(0, 0);
            painChart1.Margin = new Padding(4, 5, 4, 5);
            painChart1.MatchAxesScreenDataRatio = false;
            painChart1.MinimumSize = new Size(1756, 1420);
            painChart1.Name = "painChart1";
            painChart1.Size = new Size(1756, 1420);
            painChart1.TabIndex = 7;
            // 
            // leftPanel
            // 
            leftPanel.AutoSize = true;
            leftPanel.BackColor = Color.MediumPurple;
            leftPanel.Controls.Add(patientLabel);
            leftPanel.Controls.Add(patientsBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.MinimumSize = new Size(350, 1411);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(350, 1420);
            leftPanel.TabIndex = 8;
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientLabel.Location = new Point(12, 15);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(333, 54);
            patientLabel.TabIndex = 2;
            patientLabel.Text = "Available Patients";
            // 
            // patientsBox
            // 
            patientsBox.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsBox.FormattingEnabled = true;
            patientsBox.Location = new Point(24, 82);
            patientsBox.Name = "patientsBox";
            patientsBox.Size = new Size(304, 58);
            patientsBox.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(graphPanel);
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Controls.Add(rightPanel);
            mainPanel.Location = new Point(0, 106);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(2384, 1420);
            mainPanel.TabIndex = 10;
            // 
            // graphPanel
            // 
            graphPanel.Controls.Add(graphLabel);
            graphPanel.Controls.Add(painChart1);
            graphPanel.Dock = DockStyle.Fill;
            graphPanel.Location = new Point(350, 0);
            graphPanel.Name = "graphPanel";
            graphPanel.Size = new Size(1684, 1420);
            graphPanel.TabIndex = 10;
            // 
            // graphLabel
            // 
            graphLabel.Anchor = AnchorStyles.Top;
            graphLabel.AutoSize = true;
            graphLabel.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
            graphLabel.Location = new Point(623, 39);
            graphLabel.Name = "graphLabel";
            graphLabel.Size = new Size(465, 72);
            graphLabel.TabIndex = 11;
            graphLabel.Text = "Pain Input vs Time";
            // 
            // refreshTimer
            // 
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += refreshTimer_Tick;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(HiveMQtt.Client.Events.OnMessageReceivedEventArgs);
            // 
            // painReqTimer
            // 
            painReqTimer.Interval = 200000;
            painReqTimer.Tick += painReqTimer_Tick;
            // 
            // DataHub
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2384, 1526);
            Controls.Add(mainPanel);
            Controls.Add(titleLabel);
            Name = "DataHub";
            Text = "Form1";
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thresholdUpDown).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            graphPanel.ResumeLayout(false);
            graphPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Panel rightPanel;
        private Label messageLabel;
        private TextBox availableMessageText;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart painChart1;
        private Panel leftPanel;
        private Label patientLabel;
        private ComboBox patientsBox;
        private Panel mainPanel;
        private Panel graphPanel;
        private System.Windows.Forms.Timer refreshTimer;
        private BindingSource bindingSource1;
        private Label graphLabel;
        private Label painChangeLabel;
        private TextBox painChangeText;
        private Label label2;
        private NumericUpDown thresholdUpDown;
        private Label currentPainLabel;
        private TextBox currentPainBox;
        private System.Windows.Forms.Timer painReqTimer;
    }
}
