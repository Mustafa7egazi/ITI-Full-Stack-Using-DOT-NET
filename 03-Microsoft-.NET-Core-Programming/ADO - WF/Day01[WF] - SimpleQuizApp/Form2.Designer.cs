namespace Day01_WF____SimpleQuizApp
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            lbl_welcome = new Label();
            flowPanelQuestions = new FlowLayoutPanel();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Roboto Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(23, 24);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(632, 34);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Welcome , please answer the following questions";
            // 
            // flowPanelQuestions
            // 
            flowPanelQuestions.AutoScroll = true;
            flowPanelQuestions.FlowDirection = FlowDirection.TopDown;
            flowPanelQuestions.Location = new Point(0, 61);
            flowPanelQuestions.Name = "flowPanelQuestions";
            flowPanelQuestions.Size = new Size(1106, 616);
            flowPanelQuestions.TabIndex = 1;
            flowPanelQuestions.WrapContents = false;
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.SeaGreen;
            btn_submit.Dock = DockStyle.Bottom;
            btn_submit.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_submit.ForeColor = Color.White;
            btn_submit.Location = new Point(0, 683);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(1106, 41);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Submit Answers";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1106, 724);
            Controls.Add(btn_submit);
            Controls.Add(flowPanelQuestions);
            Controls.Add(lbl_welcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuizForm";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private FlowLayoutPanel flowPanelQuestions;
        private Button btn_submit;
    }
}