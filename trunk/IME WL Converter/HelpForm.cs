﻿using System;
using System.Windows.Forms;

namespace Studyzy.IMEWLConverter
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            string helpString = "1.1版支持搜狗的细胞词库（scel格式）的转换，您可以到搜狗网站下载细胞词库导入到您其他输入法或者手机输入法中！\r\nQQ的分类词库格式还没有研究出来怎么解析。\r\n";
            helpString += "1.2版支持了紫光拼音输入法和拼音加加输入法的词库导入导出功能。增加了批量导入的功能。修复了有些scel格式词库导入时报错\r\n";
            helpString += "1.3版改进汉字自动注音功能，可以对纯汉字的词库进行注音和转换；并可设置不显示转换结果而直接导出结果以提高超大词库的转换效率\r\n";
            helpString += "1.4版增加了对触宝输入法的支持，增加了拖拽功能。";
            helpString += "1.5版增加了百度分类词库bdict格式的转换，增加了命令行调用功能。";
            helpString += "1.6版修改了搜狗细胞词库解析和QQ手机词库解析的函数，支持最新格式。";
            helpString += "1.7版增加了对QQ输入法分类词库(qpyd格式)的解析，可像搜狗细胞词库一样的将QQ分类词库导为文本了！";
            helpString += "1.8版增加了自定义编码的输出，增强了命令行功能。实现了小小输入法和微软拼音输入法的词库功能，但是由于输入法的原因，可能会导入失败。";
            helpString += "有任何问题和建议请联系我：studyzy@163.com\r\n";
            helpString += "\r\nPS:QQ分类词库（QPYD格式）的词库在keke的帮助下实现了解析，特此表示感谢。触宝输入法词库和bcd格式词库还无法生成，谁有办法还请帮帮忙，指点一下！";
            richTextBox1.Text = helpString;
        }
    }
}