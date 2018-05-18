using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleLatex.Helper
{
    public class Constants
    {
        //DB Name
        public const string DbName = "db_stylelatex.db";

        //File Names
        public const string ArticleTexName = "article_preview";
        public const string ReportTexName = "report_preview";
        public const string DocClsName = "doc";
        public const string BstName = "bib_style";
        public const string BibName = "mybib";
        public const string BibTexName = "bib_preview";
        public const string NumericFile = "plain.txt";
        public const string AlphaFile = "alpha.txt";
        public const string AbstractFile = "abstract.txt";
        public const string AuthorYearfile = "apalike.txt";
        public const string NubericBibItemFile = "num_bibitem.txt";
        public const string BibItemFile = "bibitem.txt";

        //Path Files
        public const string PathDocFile = @"Texfiles\docstyle\";
        public const string PathBibFile = @"Texfiles\bibstyle\";
        public const string PathCiteFile = @"Texfiles\citation\";
      
        //Latex Codes
        public const string WriteField = "format.{0}.{1} write$";
        public const string PrefixText = "       {0} {1} %prefix.{2}.{3}";
        public const string SuffixText = "       {0} {1} %suffix.{2}.{3}";
        public const string FieldText = "       {2} {0} %field.{1}.{2}";
        public const string AuthorFieldText = "       {2} format.names.{2} {0} %field.{1}.{2}";
        public const string EndText = "       {0} %end.{1}.{2}";
        public const string ConcatText = "       {0} %concat.{1}.{2}";
        public const string NewEntryFormat = "    {0}  %entry.{0}";
        public const string AuthorNameFormat = "     {{ s nameptr \"{0}\" format.name$ 't := %{1}.format";
        public const string AuthorFormatCheck = "%{0}.format";
        public const string FormatAuthorFunction = " format.names.{0}";
        public const string AllPartFormat = "{{{0}}}{{{1}}}{{{2}}}{{{3}}}";
        public const string BetweenFormat = "                {{ \"{0}\" * t * }} %{1}.between";
        public const string BeforeLastFormat = "                {{ \"{0}\" * }} %{1}.beforelast";
        public const string OthersFormat = "                {{ \"{0}\" * }} %{1}.others";
        public const string DefineColorCommand = @"\definecolor{0}{{RGB}}{1}";
        public const string ColorCommand = @"\color{0}";

        public const string TitleFormatCommand = @"\titleformat{0}{1}{2}{{{3}}}{{1em}}{4}{5}";
        public const string NewFontCommand = @"\newfontfamily{0}{1}";

        public const string MainFontCommand = @"\setmainfont{0}[SizeFeatures = {{ Size = {1} }}]";
        public const string FontSizeCommand = @"\fontsize{0}{1}\selectfont";
        public const string HyperrefFormat = @"\RequirePackage[linktoc={0}]{{hyperref}}";
        public const string LeaderLineFormat = @"\renewcommand{{\cftdot}}{{{0}}}";
        public const string NumberingFormat = @"\renewcommand{{{0}}}{{{1}}} ";
        public const string ContentNameFormat = @"\renewcommand{0}{{{1}}}";
        public const string ContentNameDefault = @"\renewcommand{0}{{\color{1}\normalfont{{{2}}}\hfill}}";
        public const string AbstractNameDefault = @"\renewcommand{0}{{\hfill{{\color{1}\normalfont{{{2}}}\hfill}}}}";
        public const string ContentColorDefault = @"\definecolor{0}{{RGB}}{{0, 0, 0}}";

        public const string TextAboveFormat = @"\addtocontents{{{0}}}{{{1}\hfill{2}\par}}  %text.above.{0}";
        public const string FontSizeSecTocCommand = @"\addtocontents{{toc}}{{\fontsize{{{0}}}{{{1}}}\selectfont}}  %mainfont.size";

        //Latex Comments for Check line
        public const string AddEntryCheck = "%new.entry";
        public const string EntryCheck = "%entry.{0}";
        public const string PrefixCheck = "%prefix.{0}.{1}";
        public const string SuffixCheck = "%suffix.{0}.{1}";
        public const string FieldCheck = "%field.{0}.{1}";
        public const string EndCheck = "%end.{0}.{1}";
        public const string ConcatCheck = "%concat.{0}.{1}";
        public const string BstInitFunction = "%initial.function";
        public const string BetweenCheck = "%{0}.between";
        public const string BeforeLastCheck = "%{0}.beforelast";
        public const string OthersCheck = "%{0}.others";

        //Labels 
        public const string StrCheckBoxAbrv = "Enable Abbreviated {0}s";
        public const string StrLabelOrder = "Select Part of {0}'s Name to Order";
        public const string StrGroupSeperator = "{0}s Seperator";
        public const string StrGroupAbrv = "Abbreviated {0}s";
        public const string StrLabelShow = "{0}s";
        public const string StrTabFormat = "{0} Format";
        public const string StrTabLists = "{0} Lists";

        public const string Name = "name";
        public const string Option = "option";
        public const string MenuType = "menutype";

        public const string RequirePackage = "RequirePackage";
        public const string LoadClass = "LoadClass";
        public const string Unit = "Unit";
        public const string Article = "{article}";
        public const string Geometry = "{geometry}";

        public const string DefineColorBegin = "%definecolor";
        public const string NewFontBegin = "%newfontfamily";
        public const string TitleFormatBegin = "%titleformat";
        public const string MainFontBegin = "%setmainfont";
        public const string PreTitleBegin = "%pretitle";


    }
}
