﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Ingressos_CCXP
{
    public partial class Form1 : Form
    {
        //String comeco_tabela = @"<table class='table table-bordered table-condensed'>";
        //String fim_tabela = "<p class='hide' id='amount_warning'>";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("https://eventioz.com.br/e/comic-con-experience--4/registrations/new?iframe=");
            //String pagina_html = new WebClient().DownloadString("https://eventioz.com.br/e/comic-con-experience--4/registrations/new?iframe=");
            //pagina_html = pagina_html.Remove(0, pagina_html.IndexOf(comeco_tabela));
            //pagina_html = pagina_html.Remove(pagina_html.IndexOf(fim_tabela));
            //string retorno = "<html><head></head><body>" +
            //    "<table class='table table-bordered table-condensed'>\n<thead>\n<tr>\n<th class='tw200'>DescriÃ§Ã£o</th>\n<th class='tw90'>DisponÃ­vel atÃ©</th>\n<th class='tw90 twdefault'>Quant.</th>\n<th>Valor</th>\n</tr>\n</thead>\n<tbody>\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\n1/2 entrada ou ingresso social quinta-feira 04/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<select class=\"input-mini\" id=\"prices_114119\" name=\"prices[114119]\"><option value=\"\">0</option><option value=\"1\">1</option>\n<option value=\"2\">2</option>\n<option value=\"3\">3</option>\n<option value=\"4\">4</option>\n<option value=\"5\">5</option>\n<option value=\"6\">6</option>\n<option value=\"7\">7</option>\n<option value=\"8\">8</option>\n<option value=\"9\">9</option>\n<option value=\"10\">10</option></select>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 69,99</span>\n<input id=\"amount_for_114119\" name=\"amount_for_114119\" type=\"hidden\" value=\"69.99\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\n1/2 entrada ou ingresso social sexta-feira 05/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<select class=\"input-mini\" id=\"prices_114120\" name=\"prices[114120]\"><option value=\"\">0</option><option value=\"1\">1</option>\n<option value=\"2\">2</option>\n<option value=\"3\">3</option>\n<option value=\"4\">4</option>\n<option value=\"5\">5</option>\n<option value=\"6\">6</option>\n<option value=\"7\">7</option>\n<option value=\"8\">8</option>\n<option value=\"9\">9</option>\n<option value=\"10\">10</option></select>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 69,99</span>\n<input id=\"amount_for_114120\" name=\"amount_for_114120\" type=\"hidden\" value=\"69.99\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\n1/2 entrada ou ingresso social sÃ¡bado 06/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<span class='grey decoration-none'>NÃ£o estÃ¡ disponÃ­vel</span>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 69,99</span>\n<input id=\"amount_for_114123\" name=\"amount_for_114123\" type=\"hidden\" value=\"69.99\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\n1/2 entrada ou ingresso social domingo 07/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<span class='grey decoration-none'>NÃ£o estÃ¡ disponÃ­vel</span>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 69,99</span>\n<input id=\"amount_for_114124\" name=\"amount_for_114124\" type=\"hidden\" value=\"69.99\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\n1/2 entrada ou ingresso social 4 dias\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<select class=\"input-mini\" id=\"prices_114125\" name=\"prices[114125]\"><option value=\"\">0</option><option value=\"1\">1</option>\n<option value=\"2\">2</option>\n<option value=\"3\">3</option>\n<option value=\"4\">4</option>\n<option value=\"5\">5</option>\n<option value=\"6\">6</option>\n<option value=\"7\">7</option>\n<option value=\"8\">8</option>\n<option value=\"9\">9</option>\n<option value=\"10\">10</option></select>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 199,99</span>\n<input id=\"amount_for_114125\" name=\"amount_for_114125\" type=\"hidden\" value=\"199.99\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\nInteira quinta-feira 04/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<select class=\"input-mini\" id=\"prices_114160\" name=\"prices[114160]\"><option value=\"\">0</option><option value=\"1\">1</option>\n<option value=\"2\">2</option>\n<option value=\"3\">3</option>\n<option value=\"4\">4</option>\n<option value=\"5\">5</option>\n<option value=\"6\">6</option>\n<option value=\"7\">7</option>\n<option value=\"8\">8</option>\n<option value=\"9\">9</option>\n<option value=\"10\">10</option></select>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 139,98</span>\n<input id=\"amount_for_114160\" name=\"amount_for_114160\" type=\"hidden\" value=\"139.98\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\nInteira sexta-feira 05/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<select class=\"input-mini\" id=\"prices_114166\" name=\"prices[114166]\"><option value=\"\">0</option><option value=\"1\">1</option>\n<option value=\"2\">2</option>\n<option value=\"3\">3</option>\n<option value=\"4\">4</option>\n<option value=\"5\">5</option>\n<option value=\"6\">6</option>\n<option value=\"7\">7</option>\n<option value=\"8\">8</option>\n<option value=\"9\">9</option>\n<option value=\"10\">10</option></select>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 139,98</span>\n<input id=\"amount_for_114166\" name=\"amount_for_114166\" type=\"hidden\" value=\"139.98\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\nInteira sÃ¡bado 06/12\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<span class='grey decoration-none'>NÃ£o estÃ¡ disponÃ­vel</span>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 139,98</span>\n<input id=\"amount_for_114167\" name=\"amount_for_114167\" type=\"hidden\" value=\"139.98\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\nInteira domingo\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<span class='grey decoration-none'>NÃ£o estÃ¡ disponÃ­vel</span>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 139,98</span>\n<input id=\"amount_for_114168\" name=\"amount_for_114168\" type=\"hidden\" value=\"139.98\" />\n</p>\n</td>\n</tr>\n\n<tr>\n<td class='tw200'>\n<p class='pricebold'>\nInteira 4 dias\n</p>\n</td>\n<td>\n<p>30/06/2014 </p>\n\n</td>\n<td>\n<select class=\"input-mini\" id=\"prices_114169\" name=\"prices[114169]\"><option value=\"\">0</option><option value=\"1\">1</option>\n<option value=\"2\">2</option>\n<option value=\"3\">3</option>\n<option value=\"4\">4</option>\n<option value=\"5\">5</option>\n<option value=\"6\">6</option>\n<option value=\"7\">7</option>\n<option value=\"8\">8</option>\n<option value=\"9\">9</option>\n<option value=\"10\">10</option></select>\n</td>\n<td>\n<p>\n<span class='grey'>R$ 399,98</span>\n<input id=\"amount_for_114169\" name=\"amount_for_114169\" type=\"hidden\" value=\"399.98\" />\n</p>\n</td>\n</tr>\n\n</tbody>\n</table>\n" +
            //    "</body></html>";
            //webBrowser1.Document.Write(retorno);
            //webBrowser1.Refresh();
        }
    }
}