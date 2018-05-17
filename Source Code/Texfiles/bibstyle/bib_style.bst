ENTRY
  { 
    address  %entry.address
    author  %entry.author
    booktitle  %entry.booktitle
    chapter  %entry.chapter
    edition  %entry.edition
    editor  %entry.editor
    howpublished  %entry.howpublished
    institution  %entry.institution
    journal  %entry.journal
    key  %entry.key
    month  %entry.month
    note  %entry.note
    number  %entry.number
    organization  %entry.organization
    pages  %entry.pages
    publisher  %entry.publisher
    school  %entry.school
    series  %entry.series
    title  %entry.title
    type  %entry.type
    volume  %entry.volume
    year  %entry.year
    %new.entry
  }
  {}
  { label extra.label sort.label }

STRINGS { s t }

%start.bibitem
FUNCTION {output.bibitem}
{ newline$
  "\bibitem{" write$
  cite$ write$
  "}" write$
  newline$
  ""
}
%end.bibitem

FUNCTION {fin.entry}
{ 
  write$
  newline$
}

FUNCTION {not}
{   { #0 }
    { #1 }
  if$
}

FUNCTION {and}
{   'skip$
    { pop$ #0 }
  if$
}

FUNCTION {or}
{   { pop$ #1 }
    'skip$
  if$
}

FUNCTION {bold}
{ duplicate$ empty$
    { pop$ "" }
    { "\textbf{" swap$ * "}" * }
  if$
}

FUNCTION {italic}
{ duplicate$ empty$
    { pop$ "" }
    { "\textit{" swap$ * "}" * }
  if$
}

FUNCTION {underline}
{ duplicate$ empty$
    { pop$ "" }
    { "\underline{" swap$ * "}" * }
  if$
}

FUNCTION {field.or.null}
{ duplicate$ empty$
    { pop$ "" }
    'skip$
  if$
}

FUNCTION {sortify}
{ purify$
  "l" change.case$
}

INTEGERS { len }

FUNCTION {chop.word}
{ 's :=
  'len :=
  s #1 len substring$ =
    { s len #1 + global.max$ substring$ }
    's
  if$
}

INTEGERS { nameptr namesleft numnames }

FUNCTION {format.names.author}
{ 's :=
  #1 'nameptr :=
  s num.names$ 'numnames :=
  numnames 'namesleft :=
    { namesleft #0 > }
    { s nameptr "{ff~}{vv~}{ll}{, jj}" format.name$ 't := %author.format
      nameptr #1 >
        { namesleft #1 >
            { ", " * t * } %author.between
            { numnames #2 >
                { "," * } %author.beforelast
                'skip$
              if$
              t "others" =
                { " et~al." * } %author.others
                { " and " * t * }
              if$
            }
          if$
        }
        't
      if$
      nameptr #1 + 'nameptr :=
      namesleft #1 - 'namesleft :=
    }
  while$
}

FUNCTION {format.names.editor }
{ 's :=
  #1 'nameptr :=
  s num.names$ 'numnames :=
  numnames 'namesleft :=
    { namesleft #0 > }
    { s nameptr "{ff~}{vv~}{ll}{, jj}" format.name$ 't := %editor.format
      nameptr #1 >
        { namesleft #1 >
            { ", " * t * } %editor.between
            { numnames #2 >
                { "," * } %editor.beforelast
                'skip$
              if$
              t "others" =
                { " et~al." * } %editor.others
                { " and " * t * }
              if$
            }
          if$
        }
        't
      if$
      nameptr #1 + 'nameptr :=
      namesleft #1 - 'namesleft :=
    }
  while$
}

%initial.function

READ

%start.cite
STRINGS { longest.label }

INTEGERS { number.label longest.label.width }

FUNCTION {initialize.longest.label}
{ "" 'longest.label :=
  #1 'number.label :=
  #0 'longest.label.width :=
}

FUNCTION {longest.label.pass}
{ number.label int.to.str$ 'label :=
  number.label #1 + 'number.label :=
  label width$ longest.label.width >
    { label 'longest.label :=
      label width$ 'longest.label.width :=
    }
    'skip$
  if$
}

EXECUTE {initialize.longest.label}

ITERATE {longest.label.pass}

FUNCTION {begin.bib}
{ preamble$ empty$
    'skip$
    { preamble$ write$ newline$ }
  if$
  "\begin{thebibliography}{"  longest.label  * "}" * write$ newline$
}
%end.cite
EXECUTE {begin.bib}

ITERATE {call.type$}

FUNCTION {end.bib}
{ newline$
  "\end{thebibliography}" write$ newline$
}

EXECUTE {end.bib}