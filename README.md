IID-PDFHandler
==============

PDFHandler for IIS (Azure)

Azure websites等でPDFファイルをホストし、GET以外リクエストをすると405 Method not allowedが返ってきてしまう、
このモジュールはPDFファイルを適切なContent-type(application/pdf)で返すだけの簡単なHandlerです。

使い方
------

### Web.configの設定例 ###
   <handlers accessPolicy="Read, Script">
     <clear />
      <add name="PDFFile" 
           path="*.pdf" 
           verb="GET,POST" 
           type="PDFHandlerModule.PDFHandler"
           preCondition="integratedMode"
      />
      <add name="StaticFile"
          　path="*"
          　verb="GET,HEAD,POST,DEBUG"
          　modules="StaticFileModule,DefaultDocumentModule,DirectoryListingModule"
          　resourceType="Either"
          　requireAccess="Read"/>
    </handlers>


Lisence
----------
Copyright &copy; 2014 Misato Takahashi
Licensed under the [Apache License, Version 2.0][Apache]

[Apache]: http://www.apache.org/licenses/LICENSE-2.0
