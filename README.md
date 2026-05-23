# Limbo Syntax Highlighter

This package lets you show code examples with syntax highlighting for a few for languages. The syntax highlighting will generate HTML for you yo style using CSS.




<br /><br />

### Installation

Install the package via [**NuGet**](https://www.nuget.org/packages/Limbo.SyntaxHighlighter). To install the package, you can use either .NET CLI:

```
dotnet add package Limbo.SyntaxHighlighter
```

or the NuGet Package Manager:

```
Install-Package Limbo.SyntaxHighlighter
```



<br /><br />

### How to use?

```C#
string html = Highlighter.HighlightXml(xml);
```

```C#
string html = Highlighter.HighlightJson(json);
```

```C#
string html = Highlighter.HighlightJavaScript(javascript);
```

```C#
string html = Highlighter.HighlightCSharp(csharp);
```



<br /><br />

### Styling

Since this package is inspired by the syntax highlighting here on GitHub, the CSS below will match the colors of GitHub.

```CSS
.highlight.csharp { color: #333; font-size: 12px; line-height: 16px; }
.highlight.csharp .identifier { color: #795da3; }
.highlight.csharp .keyword { color: #a71d5d; }
.highlight.csharp .comment { color: #969896; }
.highlight.csharp .string { color: #df5000; }
.highlight.csharp .constant { color: #0086b3; }
    
.highlight.xml { color: #333; font-size: 12px; line-height: 16px; }
.highlight.xml .cdata { color: #df5000; }
.highlight.xml .cdatavalue { color: #df5000; }
.highlight.xml .element { color: #63a35c; }
.highlight.xml .attribute { color: #795da3; }
.highlight.xml .string { color: #df5000; }
.highlight.xml .quot { color: #df5000; }
.highlight.xml .comment { color: #969896; }
    
.highlight.javascript { color: #333; font-size: 12px; line-height: 16px; }
.highlight.javascript .keyword { color: #a71d5d; }
.highlight.javascript .constant { color: #0086b3; }
.highlight.javascript .string { color: #df5000; }
    
.highlight.json { color: #333; font-size: 12px; line-height: 16px; }
.highlight.json .keyword { color: #a71d5d; }
.highlight.json .constant { color: #0086b3; }
.highlight.json .string { color: #df5000; }
```
