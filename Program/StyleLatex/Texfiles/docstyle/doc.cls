\NeedsTeXFormat{LaTeX2e}
\ProvidesClass{doc}
\LoadClass{article}

\RequirePackage{titlesec}
\RequirePackage{titling}
\RequirePackage{fontspec}
\RequirePackage{titletoc}
\RequirePackage{tocloft}
\RequirePackage{caption}
\RequirePackage[linktoc=none]{hyperref}
\RequirePackage[usenames, dvipsnames]{color}
\RequirePackage{geometry}


%definecolor
\definecolor{toccolor}{RGB}{0, 0, 0}
\definecolor{lofcolor}{RGB}{0, 0, 0}
\definecolor{lotcolor}{RGB}{0, 0, 0}
\definecolor{abscolor}{RGB}{0, 0, 0}

%newfontfamily

%setmainfont

%pretitle

%titleformat

%textabovetoc

\renewcommand\contentsname{\color{toccolor}\normalfont{Contents}\hfill}
\renewcommand\listfigurename{\color{lofcolor}\normalfont{Figures}\hfill}
\renewcommand\listtablename{\color{lotcolor}\normalfont{Tables}\hfill}
\renewcommand\abstractname{\hfill\color{abscolor}\normalfont{Abstract}\hfill}

\renewcommand{\cftdot}{.}
\setcounter{tocdepth}{3}

%figurestyle
\makeatletter
\renewenvironment{figure}[1][\fps@figure]
	{\edef\@tempa{\noexpand\@float{figure}[#1]}\@tempa\centering}
	{\end@float}
\renewenvironment{table}[1][\fps@table]
	{\edef\@tempa{\noexpand\@float{table}[#1]}\@tempa\centering}
	{\end@float}
\makeatother

\captionsetup[figure]{labelformat=default, justification=centering, singlelinecheck=false}
\captionsetup[table]{labelformat=default, justification=centering, singlelinecheck=false}

\renewcommand{\thefigure}{\arabic{figure}} 
\renewcommand{\thetable}{\arabic{table}} 



