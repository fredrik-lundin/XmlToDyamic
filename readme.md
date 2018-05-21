# XmlToDynamic

## Overview
The nuget packge exposes a simple extension method on `XDocument` that can be used to transform the document to a `dynamic` object

## Usage

```
var xml = @"
        <note>
            <to>Tove</to>
            <from>Jani</from>
            <heading>Reminder</heading>
            <body>Don't forget me this weekend!</body>
        </note>
    ";
var xmlDoc = XDocument.Parse(xml);

var dynamicObject = xmlDoc.ToDynamic();
var to = dynamicObject.note.to;

Assert.Equal("Tove", to);
```
