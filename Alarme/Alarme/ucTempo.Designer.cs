namespace Alarme
{
    partial class ucTempo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucUnidadeSegundo = new Alarme.ucUnidadeTempo();
            this.ucUnidadeMinuto = new Alarme.ucUnidadeTempo();
            this.ucUnidadeHora = new Alarme.ucUnidadeTempo();
            this.SuspendLayout();
            // 
            // ucUnidadeSegundo
            // 
            this.ucUnidadeSegundo.Location = new System.Drawing.Point(163, 0);
            this.ucUnidadeSegundo.Maximo = 60;
            this.ucUnidadeSegundo.Name = "ucUnidadeSegundo";
            this.ucUnidadeSegundo.Size = new System.Drawing.Size(80, 40);
            this.ucUnidadeSegundo.TabIndex = 11;
            this.ucUnidadeSegundo.UnidadeMedida = Alarme.EnumValoresPorSegundo.SEGUNDO;
            this.ucUnidadeSegundo.Valor = 59;
            this.ucUnidadeSegundo.SetaPressionada += new Alarme.ucUnidadeTempo.SetaPressionadaEventHandler(this.ucUnidadeHora_SetaPressionada);
            // 
            // ucUnidadeMinuto
            // 
            this.ucUnidadeMinuto.Location = new System.Drawing.Point(81, 0);
            this.ucUnidadeMinuto.Maximo = 60;
            this.ucUnidadeMinuto.Name = "ucUnidadeMinuto";
            this.ucUnidadeMinuto.Size = new System.Drawing.Size(80, 40);
            this.ucUnidadeMinuto.TabIndex = 10;
            this.ucUnidadeMinuto.UnidadeMedida = Alarme.EnumValoresPorSegundo.MINUTO;
            this.ucUnidadeMinuto.Valor = 59;
            this.ucUnidadeMinuto.SetaPressionada += new Alarme.ucUnidadeTempo.SetaPressionadaEventHandler(this.ucUnidadeHora_SetaPressionada);
            // 
            // ucUnidadeHora
            // 
            this.ucUnidadeHora.Location = new System.Drawing.Point(0, 0);
            this.ucUnidadeHora.Maximo = 24;
            this.ucUnidadeHora.Name = "ucUnidadeHora";
            this.ucUnidadeHora.Size = new System.Drawing.Size(80, 40);
            this.ucUnidadeHora.TabIndex = 9;
            this.ucUnidadeHora.UnidadeMedida = Alarme.EnumValoresPorSegundo.HORA;
            this.ucUnidadeHora.Valor = 23;
            this.ucUnidadeHora.SetaPressionada += new Alarme.ucUnidadeTempo.SetaPressionadaEventHandler(this.ucUnidadeHora_SetaPressionada);
            // 
            // ucTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ucUnidadeSegundo);
            this.Controls.Add(this.ucUnidadeMinuto);
            this.Controls.Add(this.ucUnidadeHora);
            this.Name = "ucTempo";
            this.Size = new System.Drawing.Size(246, 38);
            this.ResumeLayout(false);

        }

        #endregion
        private ucUnidadeTempo ucUnidadeHora;
        private ucUnidadeTempo ucUnidadeMinuto;
        private ucUnidadeTempo ucUnidadeSegundo;
    }
}
