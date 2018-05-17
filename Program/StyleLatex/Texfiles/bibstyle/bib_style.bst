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
  "\bibitem[" write$
  label write$
  "]{" write$
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

FUNCTION {format.article.author}
{ author empty$
    { "" }
    {
       %prefix.article.author
       author format.names.author %field.article.author
       %suffix.article.author
       ". " %end.article.author
       * %concat.article.author
    }
  if$
}

FUNCTION {format.article.title}
{ title empty$
    { "" }
    {
       %prefix.article.title
       title %field.article.title
       %suffix.article.title
       ". " %end.article.title
       * %concat.article.title
    }
  if$
}

FUNCTION {format.article.journal}
{ journal empty$
    { "" }
    {
       %prefix.article.journal
       journal %field.article.journal
       %suffix.article.journal
       ". " %end.article.journal
       * %concat.article.journal
    }
  if$
}

FUNCTION {format.article.year}
{ year empty$
    { "" }
    {
       %prefix.article.year
       year %field.article.year
       %suffix.article.year
       ". " %end.article.year
       * %concat.article.year
    }
  if$
}

FUNCTION {format.article.volume}
{ volume empty$
    { "" }
    {
       %prefix.article.volume
       volume %field.article.volume
       %suffix.article.volume
       ". " %end.article.volume
       * %concat.article.volume
    }
  if$
}

FUNCTION {format.article.number}
{ number empty$
    { "" }
    {
       %prefix.article.number
       number %field.article.number
       %suffix.article.number
       ". " %end.article.number
       * %concat.article.number
    }
  if$
}

FUNCTION {format.article.pages}
{ pages empty$
    { "" }
    {
       %prefix.article.pages
       pages %field.article.pages
       %suffix.article.pages
       ". " %end.article.pages
       * %concat.article.pages
    }
  if$
}

FUNCTION {format.article.month}
{ month empty$
    { "" }
    {
       %prefix.article.month
       month %field.article.month
       %suffix.article.month
       ". " %end.article.month
       * %concat.article.month
    }
  if$
}

FUNCTION {format.article.note}
{ note empty$
    { "" }
    {
       %prefix.article.note
       note %field.article.note
       %suffix.article.note
       ". " %end.article.note
       * %concat.article.note
    }
  if$
}

%end.article.function

FUNCTION {format.book.author}
{ author empty$
    { "" }
    {
       %prefix.book.author
       author format.names.author %field.book.author
       %suffix.book.author
       ". " %end.book.author
       * %concat.book.author
    }
  if$
}

FUNCTION {format.book.title}
{ title empty$
    { "" }
    {
       %prefix.book.title
       title %field.book.title
       %suffix.book.title
       ". " %end.book.title
       * %concat.book.title
    }
  if$
}

FUNCTION {format.book.volume}
{ volume empty$
    { "" }
    {
       %prefix.book.volume
       volume %field.book.volume
       %suffix.book.volume
       ". " %end.book.volume
       * %concat.book.volume
    }
  if$
}

FUNCTION {format.book.series}
{ series empty$
    { "" }
    {
       %prefix.book.series
       series %field.book.series
       %suffix.book.series
       ". " %end.book.series
       * %concat.book.series
    }
  if$
}

FUNCTION {format.book.publisher}
{ publisher empty$
    { "" }
    {
       %prefix.book.publisher
       publisher %field.book.publisher
       %suffix.book.publisher
       ". " %end.book.publisher
       * %concat.book.publisher
    }
  if$
}

FUNCTION {format.book.address}
{ address empty$
    { "" }
    {
       %prefix.book.address
       address %field.book.address
       %suffix.book.address
       ". " %end.book.address
       * %concat.book.address
    }
  if$
}

FUNCTION {format.book.edition}
{ edition empty$
    { "" }
    {
       %prefix.book.edition
       edition %field.book.edition
       %suffix.book.edition
       ". " %end.book.edition
       * %concat.book.edition
    }
  if$
}

FUNCTION {format.book.month}
{ month empty$
    { "" }
    {
       %prefix.book.month
       month %field.book.month
       %suffix.book.month
       ". " %end.book.month
       * %concat.book.month
    }
  if$
}

FUNCTION {format.book.year}
{ year empty$
    { "" }
    {
       %prefix.book.year
       year %field.book.year
       %suffix.book.year
       ". " %end.book.year
       * %concat.book.year
    }
  if$
}

FUNCTION {format.book.note}
{ note empty$
    { "" }
    {
       %prefix.book.note
       note %field.book.note
       %suffix.book.note
       ". " %end.book.note
       * %concat.book.note
    }
  if$
}

%end.book.function

FUNCTION {format.booklet.author}
{ author empty$
    { "" }
    {
       %prefix.booklet.author
       author format.names.author %field.booklet.author
       %suffix.booklet.author
       ". " %end.booklet.author
       * %concat.booklet.author
    }
  if$
}

FUNCTION {format.booklet.title}
{ title empty$
    { "" }
    {
       %prefix.booklet.title
       title %field.booklet.title
       %suffix.booklet.title
       ". " %end.booklet.title
       * %concat.booklet.title
    }
  if$
}

FUNCTION {format.booklet.howpublished}
{ howpublished empty$
    { "" }
    {
       %prefix.booklet.howpublished
       howpublished %field.booklet.howpublished
       %suffix.booklet.howpublished
       ". " %end.booklet.howpublished
       * %concat.booklet.howpublished
    }
  if$
}

FUNCTION {format.booklet.address}
{ address empty$
    { "" }
    {
       %prefix.booklet.address
       address %field.booklet.address
       %suffix.booklet.address
       ". " %end.booklet.address
       * %concat.booklet.address
    }
  if$
}

FUNCTION {format.booklet.month}
{ month empty$
    { "" }
    {
       %prefix.booklet.month
       month %field.booklet.month
       %suffix.booklet.month
       ". " %end.booklet.month
       * %concat.booklet.month
    }
  if$
}

FUNCTION {format.booklet.year}
{ year empty$
    { "" }
    {
       %prefix.booklet.year
       year %field.booklet.year
       %suffix.booklet.year
       ". " %end.booklet.year
       * %concat.booklet.year
    }
  if$
}

FUNCTION {format.booklet.note}
{ note empty$
    { "" }
    {
       %prefix.booklet.note
       note %field.booklet.note
       %suffix.booklet.note
       ". " %end.booklet.note
       * %concat.booklet.note
    }
  if$
}

%end.booklet.function

FUNCTION {format.conference.author}
{ author empty$
    { "" }
    {
       %prefix.conference.author
       author format.names.author %field.conference.author
       %suffix.conference.author
       ". " %end.conference.author
       * %concat.conference.author
    }
  if$
}

FUNCTION {format.conference.title}
{ title empty$
    { "" }
    {
       %prefix.conference.title
       title %field.conference.title
       %suffix.conference.title
       ". " %end.conference.title
       * %concat.conference.title
    }
  if$
}

FUNCTION {format.conference.editor}
{ editor empty$
    { "" }
    {
       %prefix.conference.editor
       editor format.names.editor %field.conference.editor
       %suffix.conference.editor
       ". " %end.conference.editor
       * %concat.conference.editor
    }
  if$
}

FUNCTION {format.conference.booktitle}
{ booktitle empty$
    { "" }
    {
       %prefix.conference.booktitle
       booktitle %field.conference.booktitle
       %suffix.conference.booktitle
       ". " %end.conference.booktitle
       * %concat.conference.booktitle
    }
  if$
}

FUNCTION {format.conference.number}
{ number empty$
    { "" }
    {
       %prefix.conference.number
       number %field.conference.number
       %suffix.conference.number
       ". " %end.conference.number
       * %concat.conference.number
    }
  if$
}

FUNCTION {format.conference.series}
{ series empty$
    { "" }
    {
       %prefix.conference.series
       series %field.conference.series
       %suffix.conference.series
       ". " %end.conference.series
       * %concat.conference.series
    }
  if$
}

FUNCTION {format.conference.pages}
{ pages empty$
    { "" }
    {
       %prefix.conference.pages
       pages %field.conference.pages
       %suffix.conference.pages
       ". " %end.conference.pages
       * %concat.conference.pages
    }
  if$
}

FUNCTION {format.conference.month}
{ month empty$
    { "" }
    {
       %prefix.conference.month
       month %field.conference.month
       %suffix.conference.month
       ". " %end.conference.month
       * %concat.conference.month
    }
  if$
}

FUNCTION {format.conference.year}
{ year empty$
    { "" }
    {
       %prefix.conference.year
       year %field.conference.year
       %suffix.conference.year
       ". " %end.conference.year
       * %concat.conference.year
    }
  if$
}

FUNCTION {format.conference.address}
{ address empty$
    { "" }
    {
       %prefix.conference.address
       address %field.conference.address
       %suffix.conference.address
       ". " %end.conference.address
       * %concat.conference.address
    }
  if$
}

FUNCTION {format.conference.organization}
{ organization empty$
    { "" }
    {
       %prefix.conference.organization
       organization %field.conference.organization
       %suffix.conference.organization
       ". " %end.conference.organization
       * %concat.conference.organization
    }
  if$
}

FUNCTION {format.conference.publisher}
{ publisher empty$
    { "" }
    {
       %prefix.conference.publisher
       publisher %field.conference.publisher
       %suffix.conference.publisher
       ". " %end.conference.publisher
       * %concat.conference.publisher
    }
  if$
}

FUNCTION {format.conference.note}
{ note empty$
    { "" }
    {
       %prefix.conference.note
       note %field.conference.note
       %suffix.conference.note
       ". " %end.conference.note
       * %concat.conference.note
    }
  if$
}

%end.conference.function

FUNCTION {format.inbook.author}
{ author empty$
    { "" }
    {
       %prefix.inbook.author
       author format.names.author %field.inbook.author
       %suffix.inbook.author
       ". " %end.inbook.author
       * %concat.inbook.author
    }
  if$
}

FUNCTION {format.inbook.title}
{ title empty$
    { "" }
    {
       %prefix.inbook.title
       title %field.inbook.title
       %suffix.inbook.title
       ". " %end.inbook.title
       * %concat.inbook.title
    }
  if$
}

FUNCTION {format.inbook.volume}
{ volume empty$
    { "" }
    {
       %prefix.inbook.volume
       volume %field.inbook.volume
       %suffix.inbook.volume
       ". " %end.inbook.volume
       * %concat.inbook.volume
    }
  if$
}

FUNCTION {format.inbook.series}
{ series empty$
    { "" }
    {
       %prefix.inbook.series
       series %field.inbook.series
       %suffix.inbook.series
       ". " %end.inbook.series
       * %concat.inbook.series
    }
  if$
}

FUNCTION {format.inbook.publisher}
{ publisher empty$
    { "" }
    {
       %prefix.inbook.publisher
       publisher %field.inbook.publisher
       %suffix.inbook.publisher
       ". " %end.inbook.publisher
       * %concat.inbook.publisher
    }
  if$
}

FUNCTION {format.inbook.address}
{ address empty$
    { "" }
    {
       %prefix.inbook.address
       address %field.inbook.address
       %suffix.inbook.address
       ". " %end.inbook.address
       * %concat.inbook.address
    }
  if$
}

FUNCTION {format.inbook.edition}
{ edition empty$
    { "" }
    {
       %prefix.inbook.edition
       edition %field.inbook.edition
       %suffix.inbook.edition
       ". " %end.inbook.edition
       * %concat.inbook.edition
    }
  if$
}

FUNCTION {format.inbook.month}
{ month empty$
    { "" }
    {
       %prefix.inbook.month
       month %field.inbook.month
       %suffix.inbook.month
       ". " %end.inbook.month
       * %concat.inbook.month
    }
  if$
}

FUNCTION {format.inbook.year}
{ year empty$
    { "" }
    {
       %prefix.inbook.year
       year %field.inbook.year
       %suffix.inbook.year
       ". " %end.inbook.year
       * %concat.inbook.year
    }
  if$
}

FUNCTION {format.inbook.type}
{ type empty$
    { "" }
    {
       %prefix.inbook.type
       type %field.inbook.type
       %suffix.inbook.type
       ". " %end.inbook.type
       * %concat.inbook.type
    }
  if$
}

FUNCTION {format.inbook.chapter}
{ chapter empty$
    { "" }
    {
       %prefix.inbook.chapter
       chapter %field.inbook.chapter
       %suffix.inbook.chapter
       ". " %end.inbook.chapter
       * %concat.inbook.chapter
    }
  if$
}

FUNCTION {format.inbook.pages}
{ pages empty$
    { "" }
    {
       %prefix.inbook.pages
       pages %field.inbook.pages
       %suffix.inbook.pages
       ". " %end.inbook.pages
       * %concat.inbook.pages
    }
  if$
}

FUNCTION {format.inbook.note}
{ note empty$
    { "" }
    {
       %prefix.inbook.note
       note %field.inbook.note
       %suffix.inbook.note
       ". " %end.inbook.note
       * %concat.inbook.note
    }
  if$
}

%end.inbook.function

FUNCTION {format.incollection.author}
{ author empty$
    { "" }
    {
       %prefix.incollection.author
       author format.names.author %field.incollection.author
       %suffix.incollection.author
       ". " %end.incollection.author
       * %concat.incollection.author
    }
  if$
}

FUNCTION {format.incollection.title}
{ title empty$
    { "" }
    {
       %prefix.incollection.title
       title %field.incollection.title
       %suffix.incollection.title
       ". " %end.incollection.title
       * %concat.incollection.title
    }
  if$
}

FUNCTION {format.incollection.editor}
{ editor empty$
    { "" }
    {
       %prefix.incollection.editor
       editor format.names.editor %field.incollection.editor
       %suffix.incollection.editor
       ". " %end.incollection.editor
       * %concat.incollection.editor
    }
  if$
}

FUNCTION {format.incollection.booktitle}
{ booktitle empty$
    { "" }
    {
       %prefix.incollection.booktitle
       booktitle %field.incollection.booktitle
       %suffix.incollection.booktitle
       ". " %end.incollection.booktitle
       * %concat.incollection.booktitle
    }
  if$
}

FUNCTION {format.incollection.number}
{ number empty$
    { "" }
    {
       %prefix.incollection.number
       number %field.incollection.number
       %suffix.incollection.number
       ". " %end.incollection.number
       * %concat.incollection.number
    }
  if$
}

FUNCTION {format.incollection.series}
{ series empty$
    { "" }
    {
       %prefix.incollection.series
       series %field.incollection.series
       %suffix.incollection.series
       ". " %end.incollection.series
       * %concat.incollection.series
    }
  if$
}

FUNCTION {format.incollection.chapter}
{ chapter empty$
    { "" }
    {
       %prefix.incollection.chapter
       chapter %field.incollection.chapter
       %suffix.incollection.chapter
       ". " %end.incollection.chapter
       * %concat.incollection.chapter
    }
  if$
}

FUNCTION {format.incollection.type}
{ type empty$
    { "" }
    {
       %prefix.incollection.type
       type %field.incollection.type
       %suffix.incollection.type
       ". " %end.incollection.type
       * %concat.incollection.type
    }
  if$
}

FUNCTION {format.incollection.pages}
{ pages empty$
    { "" }
    {
       %prefix.incollection.pages
       pages %field.incollection.pages
       %suffix.incollection.pages
       ". " %end.incollection.pages
       * %concat.incollection.pages
    }
  if$
}

FUNCTION {format.incollection.publisher}
{ publisher empty$
    { "" }
    {
       %prefix.incollection.publisher
       publisher %field.incollection.publisher
       %suffix.incollection.publisher
       ". " %end.incollection.publisher
       * %concat.incollection.publisher
    }
  if$
}

FUNCTION {format.incollection.address}
{ address empty$
    { "" }
    {
       %prefix.incollection.address
       address %field.incollection.address
       %suffix.incollection.address
       ". " %end.incollection.address
       * %concat.incollection.address
    }
  if$
}

FUNCTION {format.incollection.edition}
{ edition empty$
    { "" }
    {
       %prefix.incollection.edition
       edition %field.incollection.edition
       %suffix.incollection.edition
       ". " %end.incollection.edition
       * %concat.incollection.edition
    }
  if$
}

FUNCTION {format.incollection.month}
{ month empty$
    { "" }
    {
       %prefix.incollection.month
       month %field.incollection.month
       %suffix.incollection.month
       ". " %end.incollection.month
       * %concat.incollection.month
    }
  if$
}

FUNCTION {format.incollection.year}
{ year empty$
    { "" }
    {
       %prefix.incollection.year
       year %field.incollection.year
       %suffix.incollection.year
       ". " %end.incollection.year
       * %concat.incollection.year
    }
  if$
}

FUNCTION {format.incollection.note}
{ note empty$
    { "" }
    {
       %prefix.incollection.note
       note %field.incollection.note
       %suffix.incollection.note
       ". " %end.incollection.note
       * %concat.incollection.note
    }
  if$
}

%end.incollection.function

FUNCTION {format.inproceedings.author}
{ author empty$
    { "" }
    {
       %prefix.inproceedings.author
       author format.names.author %field.inproceedings.author
       %suffix.inproceedings.author
       ". " %end.inproceedings.author
       * %concat.inproceedings.author
    }
  if$
}

FUNCTION {format.inproceedings.title}
{ title empty$
    { "" }
    {
       %prefix.inproceedings.title
       title %field.inproceedings.title
       %suffix.inproceedings.title
       ". " %end.inproceedings.title
       * %concat.inproceedings.title
    }
  if$
}

FUNCTION {format.inproceedings.editor}
{ editor empty$
    { "" }
    {
       %prefix.inproceedings.editor
       editor format.names.editor %field.inproceedings.editor
       %suffix.inproceedings.editor
       ". " %end.inproceedings.editor
       * %concat.inproceedings.editor
    }
  if$
}

FUNCTION {format.inproceedings.booktitle}
{ booktitle empty$
    { "" }
    {
       %prefix.inproceedings.booktitle
       booktitle %field.inproceedings.booktitle
       %suffix.inproceedings.booktitle
       ". " %end.inproceedings.booktitle
       * %concat.inproceedings.booktitle
    }
  if$
}

FUNCTION {format.inproceedings.number}
{ number empty$
    { "" }
    {
       %prefix.inproceedings.number
       number %field.inproceedings.number
       %suffix.inproceedings.number
       ". " %end.inproceedings.number
       * %concat.inproceedings.number
    }
  if$
}

FUNCTION {format.inproceedings.series}
{ series empty$
    { "" }
    {
       %prefix.inproceedings.series
       series %field.inproceedings.series
       %suffix.inproceedings.series
       ". " %end.inproceedings.series
       * %concat.inproceedings.series
    }
  if$
}

FUNCTION {format.inproceedings.pages}
{ pages empty$
    { "" }
    {
       %prefix.inproceedings.pages
       pages %field.inproceedings.pages
       %suffix.inproceedings.pages
       ". " %end.inproceedings.pages
       * %concat.inproceedings.pages
    }
  if$
}

FUNCTION {format.inproceedings.month}
{ month empty$
    { "" }
    {
       %prefix.inproceedings.month
       month %field.inproceedings.month
       %suffix.inproceedings.month
       ". " %end.inproceedings.month
       * %concat.inproceedings.month
    }
  if$
}

FUNCTION {format.inproceedings.year}
{ year empty$
    { "" }
    {
       %prefix.inproceedings.year
       year %field.inproceedings.year
       %suffix.inproceedings.year
       ". " %end.inproceedings.year
       * %concat.inproceedings.year
    }
  if$
}

FUNCTION {format.inproceedings.address}
{ address empty$
    { "" }
    {
       %prefix.inproceedings.address
       address %field.inproceedings.address
       %suffix.inproceedings.address
       ". " %end.inproceedings.address
       * %concat.inproceedings.address
    }
  if$
}

FUNCTION {format.inproceedings.organization}
{ organization empty$
    { "" }
    {
       %prefix.inproceedings.organization
       organization %field.inproceedings.organization
       %suffix.inproceedings.organization
       ". " %end.inproceedings.organization
       * %concat.inproceedings.organization
    }
  if$
}

FUNCTION {format.inproceedings.publisher}
{ publisher empty$
    { "" }
    {
       %prefix.inproceedings.publisher
       publisher %field.inproceedings.publisher
       %suffix.inproceedings.publisher
       ". " %end.inproceedings.publisher
       * %concat.inproceedings.publisher
    }
  if$
}

FUNCTION {format.inproceedings.note}
{ note empty$
    { "" }
    {
       %prefix.inproceedings.note
       note %field.inproceedings.note
       %suffix.inproceedings.note
       ". " %end.inproceedings.note
       * %concat.inproceedings.note
    }
  if$
}

%end.inproceedings.function

FUNCTION {format.manual.author}
{ author empty$
    { "" }
    {
       %prefix.manual.author
       author format.names.author %field.manual.author
       %suffix.manual.author
       ". " %end.manual.author
       * %concat.manual.author
    }
  if$
}

FUNCTION {format.manual.title}
{ title empty$
    { "" }
    {
       %prefix.manual.title
       title %field.manual.title
       %suffix.manual.title
       ". " %end.manual.title
       * %concat.manual.title
    }
  if$
}

FUNCTION {format.manual.organization}
{ organization empty$
    { "" }
    {
       %prefix.manual.organization
       organization %field.manual.organization
       %suffix.manual.organization
       ". " %end.manual.organization
       * %concat.manual.organization
    }
  if$
}

FUNCTION {format.manual.address}
{ address empty$
    { "" }
    {
       %prefix.manual.address
       address %field.manual.address
       %suffix.manual.address
       ". " %end.manual.address
       * %concat.manual.address
    }
  if$
}

FUNCTION {format.manual.edition}
{ edition empty$
    { "" }
    {
       %prefix.manual.edition
       edition %field.manual.edition
       %suffix.manual.edition
       ". " %end.manual.edition
       * %concat.manual.edition
    }
  if$
}

FUNCTION {format.manual.month}
{ month empty$
    { "" }
    {
       %prefix.manual.month
       month %field.manual.month
       %suffix.manual.month
       ". " %end.manual.month
       * %concat.manual.month
    }
  if$
}

FUNCTION {format.manual.year}
{ year empty$
    { "" }
    {
       %prefix.manual.year
       year %field.manual.year
       %suffix.manual.year
       ". " %end.manual.year
       * %concat.manual.year
    }
  if$
}

FUNCTION {format.manual.note}
{ note empty$
    { "" }
    {
       %prefix.manual.note
       note %field.manual.note
       %suffix.manual.note
       ". " %end.manual.note
       * %concat.manual.note
    }
  if$
}

%end.manual.function

FUNCTION {format.mastersthesis.author}
{ author empty$
    { "" }
    {
       %prefix.mastersthesis.author
       author format.names.author %field.mastersthesis.author
       %suffix.mastersthesis.author
       ". " %end.mastersthesis.author
       * %concat.mastersthesis.author
    }
  if$
}

FUNCTION {format.mastersthesis.title}
{ title empty$
    { "" }
    {
       %prefix.mastersthesis.title
       title %field.mastersthesis.title
       %suffix.mastersthesis.title
       ". " %end.mastersthesis.title
       * %concat.mastersthesis.title
    }
  if$
}

FUNCTION {format.mastersthesis.school}
{ school empty$
    { "" }
    {
       %prefix.mastersthesis.school
       school %field.mastersthesis.school
       %suffix.mastersthesis.school
       ". " %end.mastersthesis.school
       * %concat.mastersthesis.school
    }
  if$
}

FUNCTION {format.mastersthesis.type}
{ type empty$
    { "" }
    {
       %prefix.mastersthesis.type
       type %field.mastersthesis.type
       %suffix.mastersthesis.type
       ". " %end.mastersthesis.type
       * %concat.mastersthesis.type
    }
  if$
}

FUNCTION {format.mastersthesis.address}
{ address empty$
    { "" }
    {
       %prefix.mastersthesis.address
       address %field.mastersthesis.address
       %suffix.mastersthesis.address
       ". " %end.mastersthesis.address
       * %concat.mastersthesis.address
    }
  if$
}

FUNCTION {format.mastersthesis.month}
{ month empty$
    { "" }
    {
       %prefix.mastersthesis.month
       month %field.mastersthesis.month
       %suffix.mastersthesis.month
       ". " %end.mastersthesis.month
       * %concat.mastersthesis.month
    }
  if$
}

FUNCTION {format.mastersthesis.year}
{ year empty$
    { "" }
    {
       %prefix.mastersthesis.year
       year %field.mastersthesis.year
       %suffix.mastersthesis.year
       ". " %end.mastersthesis.year
       * %concat.mastersthesis.year
    }
  if$
}

FUNCTION {format.mastersthesis.note}
{ note empty$
    { "" }
    {
       %prefix.mastersthesis.note
       note %field.mastersthesis.note
       %suffix.mastersthesis.note
       ". " %end.mastersthesis.note
       * %concat.mastersthesis.note
    }
  if$
}

%end.mastersthesis.function

FUNCTION {format.misc.author}
{ author empty$
    { "" }
    {
       %prefix.misc.author
       author format.names.author %field.misc.author
       %suffix.misc.author
       ". " %end.misc.author
       * %concat.misc.author
    }
  if$
}

FUNCTION {format.misc.title}
{ title empty$
    { "" }
    {
       %prefix.misc.title
       title %field.misc.title
       %suffix.misc.title
       ". " %end.misc.title
       * %concat.misc.title
    }
  if$
}

FUNCTION {format.misc.howpublished}
{ howpublished empty$
    { "" }
    {
       %prefix.misc.howpublished
       howpublished %field.misc.howpublished
       %suffix.misc.howpublished
       ". " %end.misc.howpublished
       * %concat.misc.howpublished
    }
  if$
}

FUNCTION {format.misc.month}
{ month empty$
    { "" }
    {
       %prefix.misc.month
       month %field.misc.month
       %suffix.misc.month
       ". " %end.misc.month
       * %concat.misc.month
    }
  if$
}

FUNCTION {format.misc.year}
{ year empty$
    { "" }
    {
       %prefix.misc.year
       year %field.misc.year
       %suffix.misc.year
       ". " %end.misc.year
       * %concat.misc.year
    }
  if$
}

FUNCTION {format.misc.note}
{ note empty$
    { "" }
    {
       %prefix.misc.note
       note %field.misc.note
       %suffix.misc.note
       ". " %end.misc.note
       * %concat.misc.note
    }
  if$
}

%end.misc.function

FUNCTION {format.phdthesis.author}
{ author empty$
    { "" }
    {
       %prefix.phdthesis.author
       author format.names.author %field.phdthesis.author
       %suffix.phdthesis.author
       ". " %end.phdthesis.author
       * %concat.phdthesis.author
    }
  if$
}

FUNCTION {format.phdthesis.title}
{ title empty$
    { "" }
    {
       %prefix.phdthesis.title
       title %field.phdthesis.title
       %suffix.phdthesis.title
       ". " %end.phdthesis.title
       * %concat.phdthesis.title
    }
  if$
}

FUNCTION {format.phdthesis.school}
{ school empty$
    { "" }
    {
       %prefix.phdthesis.school
       school %field.phdthesis.school
       %suffix.phdthesis.school
       ". " %end.phdthesis.school
       * %concat.phdthesis.school
    }
  if$
}

FUNCTION {format.phdthesis.type}
{ type empty$
    { "" }
    {
       %prefix.phdthesis.type
       type %field.phdthesis.type
       %suffix.phdthesis.type
       ". " %end.phdthesis.type
       * %concat.phdthesis.type
    }
  if$
}

FUNCTION {format.phdthesis.address}
{ address empty$
    { "" }
    {
       %prefix.phdthesis.address
       address %field.phdthesis.address
       %suffix.phdthesis.address
       ". " %end.phdthesis.address
       * %concat.phdthesis.address
    }
  if$
}

FUNCTION {format.phdthesis.month}
{ month empty$
    { "" }
    {
       %prefix.phdthesis.month
       month %field.phdthesis.month
       %suffix.phdthesis.month
       ". " %end.phdthesis.month
       * %concat.phdthesis.month
    }
  if$
}

FUNCTION {format.phdthesis.year}
{ year empty$
    { "" }
    {
       %prefix.phdthesis.year
       year %field.phdthesis.year
       %suffix.phdthesis.year
       ". " %end.phdthesis.year
       * %concat.phdthesis.year
    }
  if$
}

FUNCTION {format.phdthesis.note}
{ note empty$
    { "" }
    {
       %prefix.phdthesis.note
       note %field.phdthesis.note
       %suffix.phdthesis.note
       ". " %end.phdthesis.note
       * %concat.phdthesis.note
    }
  if$
}

%end.phdthesis.function

FUNCTION {format.proceedings.editor}
{ editor empty$
    { "" }
    {
       %prefix.proceedings.editor
       editor format.names.editor %field.proceedings.editor
       %suffix.proceedings.editor
       ". " %end.proceedings.editor
       * %concat.proceedings.editor
    }
  if$
}

FUNCTION {format.proceedings.title}
{ title empty$
    { "" }
    {
       %prefix.proceedings.title
       title %field.proceedings.title
       %suffix.proceedings.title
       ". " %end.proceedings.title
       * %concat.proceedings.title
    }
  if$
}

FUNCTION {format.proceedings.number}
{ number empty$
    { "" }
    {
       %prefix.proceedings.number
       number %field.proceedings.number
       %suffix.proceedings.number
       ". " %end.proceedings.number
       * %concat.proceedings.number
    }
  if$
}

FUNCTION {format.proceedings.series}
{ series empty$
    { "" }
    {
       %prefix.proceedings.series
       series %field.proceedings.series
       %suffix.proceedings.series
       ". " %end.proceedings.series
       * %concat.proceedings.series
    }
  if$
}

FUNCTION {format.proceedings.month}
{ month empty$
    { "" }
    {
       %prefix.proceedings.month
       month %field.proceedings.month
       %suffix.proceedings.month
       ". " %end.proceedings.month
       * %concat.proceedings.month
    }
  if$
}

FUNCTION {format.proceedings.year}
{ year empty$
    { "" }
    {
       %prefix.proceedings.year
       year %field.proceedings.year
       %suffix.proceedings.year
       ". " %end.proceedings.year
       * %concat.proceedings.year
    }
  if$
}

FUNCTION {format.proceedings.address}
{ address empty$
    { "" }
    {
       %prefix.proceedings.address
       address %field.proceedings.address
       %suffix.proceedings.address
       ". " %end.proceedings.address
       * %concat.proceedings.address
    }
  if$
}

FUNCTION {format.proceedings.organization}
{ organization empty$
    { "" }
    {
       %prefix.proceedings.organization
       organization %field.proceedings.organization
       %suffix.proceedings.organization
       ". " %end.proceedings.organization
       * %concat.proceedings.organization
    }
  if$
}

FUNCTION {format.proceedings.publisher}
{ publisher empty$
    { "" }
    {
       %prefix.proceedings.publisher
       publisher %field.proceedings.publisher
       %suffix.proceedings.publisher
       ". " %end.proceedings.publisher
       * %concat.proceedings.publisher
    }
  if$
}

FUNCTION {format.proceedings.note}
{ note empty$
    { "" }
    {
       %prefix.proceedings.note
       note %field.proceedings.note
       %suffix.proceedings.note
       ". " %end.proceedings.note
       * %concat.proceedings.note
    }
  if$
}

%end.proceedings.function

FUNCTION {format.techreport.author}
{ author empty$
    { "" }
    {
       %prefix.techreport.author
       author format.names.author %field.techreport.author
       %suffix.techreport.author
       ". " %end.techreport.author
       * %concat.techreport.author
    }
  if$
}

FUNCTION {format.techreport.title}
{ title empty$
    { "" }
    {
       %prefix.techreport.title
       title %field.techreport.title
       %suffix.techreport.title
       ". " %end.techreport.title
       * %concat.techreport.title
    }
  if$
}

FUNCTION {format.techreport.institution}
{ institution empty$
    { "" }
    {
       %prefix.techreport.institution
       institution %field.techreport.institution
       %suffix.techreport.institution
       ". " %end.techreport.institution
       * %concat.techreport.institution
    }
  if$
}

FUNCTION {format.techreport.type}
{ type empty$
    { "" }
    {
       %prefix.techreport.type
       type %field.techreport.type
       %suffix.techreport.type
       ". " %end.techreport.type
       * %concat.techreport.type
    }
  if$
}

FUNCTION {format.techreport.number}
{ number empty$
    { "" }
    {
       %prefix.techreport.number
       number %field.techreport.number
       %suffix.techreport.number
       ". " %end.techreport.number
       * %concat.techreport.number
    }
  if$
}

FUNCTION {format.techreport.address}
{ address empty$
    { "" }
    {
       %prefix.techreport.address
       address %field.techreport.address
       %suffix.techreport.address
       ". " %end.techreport.address
       * %concat.techreport.address
    }
  if$
}

FUNCTION {format.techreport.month}
{ month empty$
    { "" }
    {
       %prefix.techreport.month
       month %field.techreport.month
       %suffix.techreport.month
       ". " %end.techreport.month
       * %concat.techreport.month
    }
  if$
}

FUNCTION {format.techreport.year}
{ year empty$
    { "" }
    {
       %prefix.techreport.year
       year %field.techreport.year
       %suffix.techreport.year
       ". " %end.techreport.year
       * %concat.techreport.year
    }
  if$
}

FUNCTION {format.techreport.note}
{ note empty$
    { "" }
    {
       %prefix.techreport.note
       note %field.techreport.note
       %suffix.techreport.note
       ". " %end.techreport.note
       * %concat.techreport.note
    }
  if$
}

%end.techreport.function

FUNCTION {format.unpublished.author}
{ author empty$
    { "" }
    {
       %prefix.unpublished.author
       author format.names.author %field.unpublished.author
       %suffix.unpublished.author
       ". " %end.unpublished.author
       * %concat.unpublished.author
    }
  if$
}

FUNCTION {format.unpublished.title}
{ title empty$
    { "" }
    {
       %prefix.unpublished.title
       title %field.unpublished.title
       %suffix.unpublished.title
       ". " %end.unpublished.title
       * %concat.unpublished.title
    }
  if$
}

FUNCTION {format.unpublished.month}
{ month empty$
    { "" }
    {
       %prefix.unpublished.month
       month %field.unpublished.month
       %suffix.unpublished.month
       ". " %end.unpublished.month
       * %concat.unpublished.month
    }
  if$
}

FUNCTION {format.unpublished.year}
{ year empty$
    { "" }
    {
       %prefix.unpublished.year
       year %field.unpublished.year
       %suffix.unpublished.year
       ". " %end.unpublished.year
       * %concat.unpublished.year
    }
  if$
}

FUNCTION {format.unpublished.note}
{ note empty$
    { "" }
    {
       %prefix.unpublished.note
       note %field.unpublished.note
       %suffix.unpublished.note
       ". " %end.unpublished.note
       * %concat.unpublished.note
    }
  if$
}

%end.unpublished.function

FUNCTION {article}
{
 output.bibitem
 format.article.author write$
 format.article.title write$
 format.article.journal write$
 format.article.year write$
 format.article.volume write$
 format.article.number write$
 format.article.pages write$
 format.article.month write$
 format.article.note write$
  %article.new.write
 fin.entry
}

FUNCTION {book}
{
 output.bibitem
 format.book.author write$
 format.book.title write$
 format.book.volume write$
 format.book.series write$
 format.book.publisher write$
 format.book.address write$
 format.book.edition write$
 format.book.month write$
 format.book.year write$
 format.book.note write$
  %book.new.write
 fin.entry
}

FUNCTION {booklet}
{
 output.bibitem
 format.booklet.author write$
 format.booklet.title write$
 format.booklet.howpublished write$
 format.booklet.address write$
 format.booklet.month write$
 format.booklet.year write$
 format.booklet.note write$
  %booklet.new.write
 fin.entry
}

FUNCTION {conference}
{
 output.bibitem
 format.conference.author write$
 format.conference.title write$
 format.conference.editor write$
 format.conference.booktitle write$
 format.conference.number write$
 format.conference.series write$
 format.conference.pages write$
 format.conference.month write$
 format.conference.year write$
 format.conference.address write$
 format.conference.organization write$
 format.conference.publisher write$
 format.conference.note write$
  %conference.new.write
 fin.entry
}

FUNCTION {inbook}
{
 output.bibitem
 format.inbook.author write$
 format.inbook.title write$
 format.inbook.volume write$
 format.inbook.series write$
 format.inbook.publisher write$
 format.inbook.address write$
 format.inbook.edition write$
 format.inbook.month write$
 format.inbook.year write$
 format.inbook.type write$
 format.inbook.chapter write$
 format.inbook.pages write$
 format.inbook.note write$
  %inbook.new.write
 fin.entry
}

FUNCTION {incollection}
{
 output.bibitem
 format.incollection.author write$
 format.incollection.title write$
 format.incollection.editor write$
 format.incollection.booktitle write$
 format.incollection.number write$
 format.incollection.series write$
 format.incollection.chapter write$
 format.incollection.type write$
 format.incollection.pages write$
 format.incollection.publisher write$
 format.incollection.address write$
 format.incollection.edition write$
 format.incollection.month write$
 format.incollection.year write$
 format.incollection.note write$
  %incollection.new.write
 fin.entry
}

FUNCTION {inproceedings}
{
 output.bibitem
 format.inproceedings.author write$
 format.inproceedings.title write$
 format.inproceedings.editor write$
 format.inproceedings.booktitle write$
 format.inproceedings.number write$
 format.inproceedings.series write$
 format.inproceedings.pages write$
 format.inproceedings.month write$
 format.inproceedings.year write$
 format.inproceedings.address write$
 format.inproceedings.organization write$
 format.inproceedings.publisher write$
 format.inproceedings.note write$
  %inproceedings.new.write
 fin.entry
}

FUNCTION {manual}
{
 output.bibitem
 format.manual.author write$
 format.manual.title write$
 format.manual.organization write$
 format.manual.address write$
 format.manual.edition write$
 format.manual.month write$
 format.manual.year write$
 format.manual.note write$
  %manual.new.write
 fin.entry
}

FUNCTION {mastersthesis}
{
 output.bibitem
 format.mastersthesis.author write$
 format.mastersthesis.title write$
 format.mastersthesis.school write$
 format.mastersthesis.type write$
 format.mastersthesis.address write$
 format.mastersthesis.month write$
 format.mastersthesis.year write$
 format.mastersthesis.note write$
  %mastersthesis.new.write
 fin.entry
}

FUNCTION {misc}
{
 output.bibitem
 format.misc.author write$
 format.misc.title write$
 format.misc.howpublished write$
 format.misc.month write$
 format.misc.year write$
 format.misc.note write$
  %misc.new.write
 fin.entry
}

FUNCTION {phdthesis}
{
 output.bibitem
 format.phdthesis.author write$
 format.phdthesis.title write$
 format.phdthesis.school write$
 format.phdthesis.type write$
 format.phdthesis.address write$
 format.phdthesis.month write$
 format.phdthesis.year write$
 format.phdthesis.note write$
  %phdthesis.new.write
 fin.entry
}

FUNCTION {proceedings}
{
 output.bibitem
 format.proceedings.editor write$
 format.proceedings.title write$
 format.proceedings.number write$
 format.proceedings.series write$
 format.proceedings.month write$
 format.proceedings.year write$
 format.proceedings.address write$
 format.proceedings.organization write$
 format.proceedings.publisher write$
 format.proceedings.note write$
  %proceedings.new.write
 fin.entry
}

FUNCTION {techreport}
{
 output.bibitem
 format.techreport.author write$
 format.techreport.title write$
 format.techreport.institution write$
 format.techreport.type write$
 format.techreport.number write$
 format.techreport.address write$
 format.techreport.month write$
 format.techreport.year write$
 format.techreport.note write$
  %techreport.new.write
 fin.entry
}

FUNCTION {unpublished}
{
 output.bibitem
 format.unpublished.author write$
 format.unpublished.title write$
 format.unpublished.month write$
 format.unpublished.year write$
 format.unpublished.note write$
  %unpublished.new.write
 fin.entry
}



READ

%start.cite
FUNCTION {format.lab.names}
{ 's :=
  s #1 "{vv~}{ll}" format.name$
  s num.names$ duplicate$
  #2 >
    { pop$ " et~al." * }
    { #2 <
        'skip$
        { s #2 "{ff }{vv }{ll}{ jj}" format.name$ "others" =
            { " et~al." * }
            { " and " * s #2 "{vv~}{ll}" format.name$ * }
          if$
        }
      if$
    }
  if$
}

FUNCTION {author.key.label}
{ author empty$
    { key empty$
        { cite$ #1 #3 substring$ }
        'key                                    % apalike uses the whole key
      if$
    }
    { author format.lab.names }
  if$
}

FUNCTION {author.editor.key.label}
{ author empty$
    { editor empty$
        { key empty$
            { cite$ #1 #3 substring$ }
            'key                                % apalike uses the whole key
          if$
        }
        { editor format.lab.names }
      if$
    }
    { author format.lab.names }
  if$
}

FUNCTION {editor.key.label}
{ editor empty$
    { key empty$
        { cite$ #1 #3 substring$ }
        'key                    % apalike uses the whole key, no organization
      if$
    }
    { editor format.lab.names }
  if$
}

FUNCTION {calc.label}
{ type$ "book" =
  type$ "inbook" =
  or
    'author.editor.key.label
    { type$ "proceedings" =
        'editor.key.label                       % apalike ignores organization
        'author.key.label                       % for labeling and sorting
      if$
    }
  if$
  ", "                                                  % these three lines are
  *                                                     % for apalike, which
  year field.or.null purify$ #-1 #4 substring$          % uses all four digits
  *
  'label :=
}

FUNCTION {sort.format.names}
{ 's :=
  #1 'nameptr :=
  ""
  s num.names$ 'numnames :=
  numnames 'namesleft :=
    { namesleft #0 > }
    { nameptr #1 >
        { "   " * }
        'skip$
      if$                                               % apalike uses initials
      s nameptr "{vv{ } }{ll{ }}{  f{ }}{  jj{ }}" format.name$ 't := % <= here
      nameptr numnames = t "others" = and
        { "et al" * }
        { t sortify * }
      if$
      nameptr #1 + 'nameptr :=
      namesleft #1 - 'namesleft :=
    }
  while$
}

FUNCTION {sort.format.title}
{ 't :=
  "A " #2
    "An " #3
      "The " #4 t chop.word
    chop.word
  chop.word
  sortify
  #1 global.max$ substring$
}

FUNCTION {author.sort}
{ author empty$
    { key empty$
        { "to sort, need author or key in " cite$ * warning$
          ""
        }
        { key sortify }
      if$
    }
    { author sort.format.names }
  if$
}

FUNCTION {author.editor.sort}
{ author empty$
    { editor empty$
        { key empty$
            { "to sort, need author, editor, or key in " cite$ * warning$
              ""
            }
            { key sortify }
          if$
        }
        { editor sort.format.names }
      if$
    }
    { author sort.format.names }
  if$
}

FUNCTION {editor.sort}
{ editor empty$
    { key empty$
        { "to sort, need editor or key in " cite$ * warning$
          ""
        }
        { key sortify }
      if$
    }
    { editor sort.format.names }
  if$
}

FUNCTION {presort}
{ calc.label
  label sortify
  "    "
  *
  type$ "book" =
  type$ "inbook" =
  or
    'author.editor.sort
    { type$ "proceedings" =
        'editor.sort
        'author.sort
      if$
    }
  if$
  #1 entry.max$ substring$      
  'sort.label :=                
  sort.label                    
  *
  "    "
  *
  title field.or.null
  sort.format.title
  *
  #1 entry.max$ substring$
  'sort.key$ :=
}

ITERATE {presort}

SORT            % by label, sort.label, title---for final label calculation

STRINGS { last.label next.extra }       % apalike labels are only for the text;

INTEGERS { last.extra.num }             % there are none in the bibliography

FUNCTION {initialize.extra.label.stuff} % and hence there is no `longest.label'
{ #0 int.to.chr$ 'last.label :=
  "" 'next.extra :=
  #0 'last.extra.num :=
}

FUNCTION {forward.pass}
{ last.label label =
    { last.extra.num #1 + 'last.extra.num :=
      last.extra.num int.to.chr$ 'extra.label :=
    }
    { "a" chr.to.int$ 'last.extra.num :=
      "" 'extra.label :=
      label 'last.label :=
    }
  if$
}

FUNCTION {reverse.pass}
{ next.extra "b" =
    { "a" 'extra.label := }
    'skip$
  if$
  label extra.label * 'label :=
  extra.label 'next.extra :=
}

EXECUTE {initialize.extra.label.stuff}

ITERATE {forward.pass}

REVERSE {reverse.pass}

FUNCTION {bib.sort.order}
{ sort.label
  "    "
  *
  year field.or.null sortify
  *
  "    "
  *
  title field.or.null
  sort.format.title
  *
  #1 entry.max$ substring$
  'sort.key$ :=
}

ITERATE {bib.sort.order}

SORT            % by sort.label, year, title---giving final bibliography order

FUNCTION {begin.bib}
{ preamble$ empty$                              % no \etalchar in apalike
    'skip$
    { preamble$ write$ newline$ }
  if$
  "\begin{thebibliography}{}" write$ newline$           % no labels in apalike
}

%end.cite
EXECUTE {begin.bib}

ITERATE {call.type$}

FUNCTION {end.bib}
{ newline$
  "\end{thebibliography}" write$ newline$
}

EXECUTE {end.bib}