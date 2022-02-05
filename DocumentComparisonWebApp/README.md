Objective: This is a web based application to compare the MS Word Documents and show the comparison on the web browser.

-------------------------------------------------------------------------------------------------------------

To Run The Web Application
> Set "DocumentComparison" project as the Start-up Project
> Open Package Manager Console and Run This Command, missing this step will cause Build Error.
	Install-Package Aspose.Words -Version 21.10.0
> Run the project with Google Chrome
> One Grid will show up listing all the documents
> Select Document version 1 and Document version 3 and click on Compare Document Button
> The comparison will show on a popup

-------------------------------------------------------------------------------------------------------------

The comparison results screenshots with different versions of Aspose.Word librray 
(i.e. v20.1.0, v21.9.0, v21.10.0 – latest build) are available on the directory {RootDirectory}/DocumentComparison/Images

-------------------------------------------------------------------------------------------------------------

Assets/ Images/ Results of Console App:
> ReadMe.md
> Documents: {RootDirectory}/DocumentComparison/UserFiles 
> Screenshots/ Images: {RootDirectory}/DocumentComparison/Images 

-------------------------------------------------------------------------------------------------------------

Command to Install Aspose.Words Library with different versions
> Install-Package Aspose.Words -Version 21.10.0
> Install-Package Aspose.Words -Version 21.9.0
> Install-Package Aspose.Words -Version 20.1.0

-------------------------------------------------------------------------------------------------------------

Document Comparison Description:

> In the 2nd version, "[CCA]Case Management or CM means the functionality within the Software to support...." the 2nd paragraph was removed. 
> The comparison shows the first two words from the 3rd paragraph, where "Client-Developed Code" was impacted and "client" word was redlined and added again (see screenshots in {RootDirectory}/DocumentComparison/Images for reference).

> Similarly in the 3rd version of the document, the 6th, 7th and 8th paragraph which has below mentioned content were removed but the word in the next paragraph i.e. "Developed-Code" of 10th paragraph was red-lined and added again (see screenshots in {RootDirectory}/DocumentComparison/Images for reference).

"[NON -HOSTED] Client-Provided Technology means collectively any Client Materials.... 
Client Reports is defined in Section 34 of Table 2.B. [NTD: Verify Section Number]
[NTD: Include if SI is included scope and Confirm “Software” ...."

> If we compare the version 1 and version 3, then there are content redlined and added again but which were not modfied at all.

Expected Result: The comparison should show only the changes which were performed and the untouched content should be kept as is without redlined and added again.

-------------------------------------------------------------------------------------------------------------
