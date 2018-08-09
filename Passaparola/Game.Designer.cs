namespace Passaparola
{
    partial class Game
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
            this.cgb = new System.Windows.Forms.GroupBox();
            this.corrects = new System.Windows.Forms.Label();
            this.pgb = new System.Windows.Forms.GroupBox();
            this.points = new System.Windows.Forms.Label();
            this.wgb = new System.Windows.Forms.GroupBox();
            this.wrongs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.passButton = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.gamegb = new System.Windows.Forms.GroupBox();
            this.currentLetterLabel = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelJ = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.cgb.SuspendLayout();
            this.pgb.SuspendLayout();
            this.wgb.SuspendLayout();
            this.gamegb.SuspendLayout();
            this.SuspendLayout();
            // 
            // cgb
            // 
            this.cgb.Controls.Add(this.corrects);
            this.cgb.Location = new System.Drawing.Point(12, 12);
            this.cgb.Name = "cgb";
            this.cgb.Size = new System.Drawing.Size(150, 50);
            this.cgb.TabIndex = 3;
            this.cgb.TabStop = false;
            this.cgb.Text = "Correct Answers";
            // 
            // corrects
            // 
            this.corrects.AutoSize = true;
            this.corrects.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corrects.Location = new System.Drawing.Point(44, 16);
            this.corrects.Name = "corrects";
            this.corrects.Size = new System.Drawing.Size(26, 30);
            this.corrects.TabIndex = 0;
            this.corrects.Text = "0";
            this.corrects.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pgb
            // 
            this.pgb.Controls.Add(this.points);
            this.pgb.Location = new System.Drawing.Point(324, 12);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(150, 50);
            this.pgb.TabIndex = 0;
            this.pgb.TabStop = false;
            this.pgb.Text = "Points";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.Location = new System.Drawing.Point(45, 16);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(26, 30);
            this.points.TabIndex = 2;
            this.points.Text = "0";
            this.points.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wgb
            // 
            this.wgb.Controls.Add(this.wrongs);
            this.wgb.Location = new System.Drawing.Point(168, 12);
            this.wgb.Name = "wgb";
            this.wgb.Size = new System.Drawing.Size(150, 46);
            this.wgb.TabIndex = 0;
            this.wgb.TabStop = false;
            this.wgb.Text = "Wrong Answers";
            // 
            // wrongs
            // 
            this.wrongs.AutoSize = true;
            this.wrongs.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongs.Location = new System.Drawing.Point(38, 16);
            this.wrongs.Name = "wrongs";
            this.wrongs.Size = new System.Drawing.Size(26, 30);
            this.wrongs.TabIndex = 1;
            this.wrongs.Text = "0";
            this.wrongs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOUR ANSWER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remaining Time:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(277, 63);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(15, 17);
            this.time.TabIndex = 4;
            this.time.Text = "0";
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.answerLabel.Location = new System.Drawing.Point(211, 385);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(268, 37);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerLabel_KeyPress);
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(211, 428);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(132, 28);
            this.answerButton.TabIndex = 6;
            this.answerButton.Text = "ANSWER";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // passButton
            // 
            this.passButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButton.Location = new System.Drawing.Point(349, 428);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(130, 28);
            this.passButton.TabIndex = 7;
            this.passButton.Text = "PASS";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // labelA
            // 
            this.labelA.BackColor = System.Drawing.SystemColors.Control;
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelA.Location = new System.Drawing.Point(219, 16);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(23, 23);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.BackColor = System.Drawing.SystemColors.Control;
            this.labelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelB.Location = new System.Drawing.Point(249, 16);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(23, 23);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.BackColor = System.Drawing.SystemColors.Control;
            this.labelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelC.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelC.Location = new System.Drawing.Point(278, 16);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(23, 23);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.BackColor = System.Drawing.SystemColors.Control;
            this.labelD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelD.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelD.Location = new System.Drawing.Point(307, 16);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(23, 23);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "D";
            // 
            // labelE
            // 
            this.labelE.BackColor = System.Drawing.SystemColors.Control;
            this.labelE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelE.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelE.Location = new System.Drawing.Point(336, 16);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(23, 23);
            this.labelE.TabIndex = 4;
            this.labelE.Text = "E";
            // 
            // gamegb
            // 
            this.gamegb.Controls.Add(this.currentLetterLabel);
            this.gamegb.Controls.Add(this.labelY);
            this.gamegb.Controls.Add(this.labelX);
            this.gamegb.Controls.Add(this.labelW);
            this.gamegb.Controls.Add(this.labelV);
            this.gamegb.Controls.Add(this.labelU);
            this.gamegb.Controls.Add(this.labelT);
            this.gamegb.Controls.Add(this.labelS);
            this.gamegb.Controls.Add(this.labelR);
            this.gamegb.Controls.Add(this.labelQ);
            this.gamegb.Controls.Add(this.labelP);
            this.gamegb.Controls.Add(this.labelO);
            this.gamegb.Controls.Add(this.labelN);
            this.gamegb.Controls.Add(this.labelM);
            this.gamegb.Controls.Add(this.labelL);
            this.gamegb.Controls.Add(this.labelK);
            this.gamegb.Controls.Add(this.labelJ);
            this.gamegb.Controls.Add(this.labelI);
            this.gamegb.Controls.Add(this.labelH);
            this.gamegb.Controls.Add(this.labelZ);
            this.gamegb.Controls.Add(this.labelG);
            this.gamegb.Controls.Add(this.labelF);
            this.gamegb.Controls.Add(this.labelE);
            this.gamegb.Controls.Add(this.labelD);
            this.gamegb.Controls.Add(this.labelC);
            this.gamegb.Controls.Add(this.labelB);
            this.gamegb.Controls.Add(this.labelA);
            this.gamegb.Location = new System.Drawing.Point(28, 119);
            this.gamegb.Name = "gamegb";
            this.gamegb.Size = new System.Drawing.Size(367, 160);
            this.gamegb.TabIndex = 8;
            this.gamegb.TabStop = false;
            // 
            // currentLetterLabel
            // 
            this.currentLetterLabel.BackColor = System.Drawing.SystemColors.MenuText;
            this.currentLetterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentLetterLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLetterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentLetterLabel.Location = new System.Drawing.Point(183, 45);
            this.currentLetterLabel.Name = "currentLetterLabel";
            this.currentLetterLabel.Size = new System.Drawing.Size(69, 73);
            this.currentLetterLabel.TabIndex = 27;
            this.currentLetterLabel.Text = "A";
            this.currentLetterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelY
            // 
            this.labelY.BackColor = System.Drawing.SystemColors.Control;
            this.labelY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelY.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelY.Location = new System.Drawing.Point(164, 16);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 23);
            this.labelY.TabIndex = 25;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.BackColor = System.Drawing.SystemColors.Control;
            this.labelX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelX.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX.Location = new System.Drawing.Point(135, 16);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 23);
            this.labelX.TabIndex = 24;
            this.labelX.Text = "X";
            // 
            // labelW
            // 
            this.labelW.BackColor = System.Drawing.SystemColors.Control;
            this.labelW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelW.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelW.Location = new System.Drawing.Point(106, 16);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(23, 23);
            this.labelW.TabIndex = 23;
            this.labelW.Text = "W";
            // 
            // labelV
            // 
            this.labelV.BackColor = System.Drawing.SystemColors.Control;
            this.labelV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelV.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelV.Location = new System.Drawing.Point(77, 16);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(23, 23);
            this.labelV.TabIndex = 22;
            this.labelV.Text = "V";
            // 
            // labelU
            // 
            this.labelU.BackColor = System.Drawing.SystemColors.Control;
            this.labelU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelU.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelU.Location = new System.Drawing.Point(77, 45);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(23, 23);
            this.labelU.TabIndex = 21;
            this.labelU.Text = "U";
            // 
            // labelT
            // 
            this.labelT.BackColor = System.Drawing.SystemColors.Control;
            this.labelT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelT.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelT.Location = new System.Drawing.Point(77, 74);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(23, 23);
            this.labelT.TabIndex = 20;
            this.labelT.Text = "T";
            // 
            // labelS
            // 
            this.labelS.BackColor = System.Drawing.SystemColors.Control;
            this.labelS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelS.Location = new System.Drawing.Point(77, 103);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(23, 23);
            this.labelS.TabIndex = 19;
            this.labelS.Text = "S";
            // 
            // labelR
            // 
            this.labelR.BackColor = System.Drawing.SystemColors.Control;
            this.labelR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelR.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelR.Location = new System.Drawing.Point(77, 133);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(23, 23);
            this.labelR.TabIndex = 18;
            this.labelR.Text = "R";
            // 
            // labelQ
            // 
            this.labelQ.BackColor = System.Drawing.SystemColors.Control;
            this.labelQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQ.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelQ.Location = new System.Drawing.Point(106, 133);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(23, 23);
            this.labelQ.TabIndex = 17;
            this.labelQ.Text = "Q";
            // 
            // labelP
            // 
            this.labelP.BackColor = System.Drawing.SystemColors.Control;
            this.labelP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelP.Location = new System.Drawing.Point(135, 133);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(23, 23);
            this.labelP.TabIndex = 16;
            this.labelP.Text = "P";
            // 
            // labelO
            // 
            this.labelO.BackColor = System.Drawing.SystemColors.Control;
            this.labelO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelO.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelO.Location = new System.Drawing.Point(164, 133);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(23, 23);
            this.labelO.TabIndex = 15;
            this.labelO.Text = "O";
            // 
            // labelN
            // 
            this.labelN.BackColor = System.Drawing.SystemColors.Control;
            this.labelN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelN.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelN.Location = new System.Drawing.Point(191, 133);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(23, 23);
            this.labelN.TabIndex = 14;
            this.labelN.Text = "N";
            // 
            // labelM
            // 
            this.labelM.BackColor = System.Drawing.SystemColors.Control;
            this.labelM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelM.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelM.Location = new System.Drawing.Point(219, 133);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(23, 23);
            this.labelM.TabIndex = 13;
            this.labelM.Text = "M";
            // 
            // labelL
            // 
            this.labelL.BackColor = System.Drawing.SystemColors.Control;
            this.labelL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelL.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelL.Location = new System.Drawing.Point(249, 133);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(23, 23);
            this.labelL.TabIndex = 12;
            this.labelL.Text = "L";
            // 
            // labelK
            // 
            this.labelK.BackColor = System.Drawing.SystemColors.Control;
            this.labelK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelK.Location = new System.Drawing.Point(278, 133);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(23, 23);
            this.labelK.TabIndex = 11;
            this.labelK.Text = "K";
            // 
            // labelJ
            // 
            this.labelJ.BackColor = System.Drawing.SystemColors.Control;
            this.labelJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJ.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelJ.Location = new System.Drawing.Point(307, 133);
            this.labelJ.Name = "labelJ";
            this.labelJ.Size = new System.Drawing.Size(23, 23);
            this.labelJ.TabIndex = 10;
            this.labelJ.Text = "J";
            // 
            // labelI
            // 
            this.labelI.BackColor = System.Drawing.SystemColors.Control;
            this.labelI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelI.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelI.Location = new System.Drawing.Point(336, 133);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(23, 23);
            this.labelI.TabIndex = 9;
            this.labelI.Text = "I";
            // 
            // labelH
            // 
            this.labelH.BackColor = System.Drawing.SystemColors.Control;
            this.labelH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelH.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelH.Location = new System.Drawing.Point(336, 103);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(23, 23);
            this.labelH.TabIndex = 8;
            this.labelH.Text = "H";
            // 
            // labelZ
            // 
            this.labelZ.BackColor = System.Drawing.SystemColors.Control;
            this.labelZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelZ.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelZ.Location = new System.Drawing.Point(191, 16);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(23, 23);
            this.labelZ.TabIndex = 7;
            this.labelZ.Text = "Z";
            // 
            // labelG
            // 
            this.labelG.BackColor = System.Drawing.SystemColors.Control;
            this.labelG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelG.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelG.Location = new System.Drawing.Point(336, 74);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(23, 23);
            this.labelG.TabIndex = 6;
            this.labelG.Text = "G";
            // 
            // labelF
            // 
            this.labelF.BackColor = System.Drawing.SystemColors.Control;
            this.labelF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelF.Location = new System.Drawing.Point(336, 45);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(23, 23);
            this.labelF.TabIndex = 5;
            this.labelF.Text = "F";
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(23, 294);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(451, 88);
            this.questionLabel.TabIndex = 9;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.gamegb);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.wgb);
            this.Controls.Add(this.cgb);
            this.Name = "Game";
            this.Text = "Passaparola";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.cgb.ResumeLayout(false);
            this.cgb.PerformLayout();
            this.pgb.ResumeLayout(false);
            this.pgb.PerformLayout();
            this.wgb.ResumeLayout(false);
            this.wgb.PerformLayout();
            this.gamegb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox cgb;
        private System.Windows.Forms.GroupBox pgb;
        private System.Windows.Forms.GroupBox wgb;
        private System.Windows.Forms.Label corrects;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label wrongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox answerLabel;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.GroupBox gamegb;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelJ;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label currentLetterLabel;
        private System.Windows.Forms.Label questionLabel;
    }
}