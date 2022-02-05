Objective: This is a simple console application to compare the MS Word Documents and show the comparison.

-------------------------------------------------------------------------------------------------------------

Steps To Run The Console Application:
> To Start With, Set "ConsoleApp" project as the Start-up Project.
> Open Package Manager Console and Run This Command, missing this step will cause Build Error.
	Install-Package Aspose.Words -Version 21.10.0
> In Program.cs file under the Main() method the document1 and document2 are hard-coded.
> Then both the documents (Document version 1 vs Document version 3) are compared using Aspose.Words library.
> Build and Run the application.
> The resultant document is saved under the directory {RootDirectory}/ConsoleApp/UserFiles

-------------------------------------------------------------------------------------------------------------

The comparison results screenshots with different versions of Aspose.Word librray 
(i.e. v20.1.0, v21.9.0, v21.10.0 – latest build) are available on the directory {RootDirectory}/ConsoleApp/Images

-------------------------------------------------------------------------------------------------------------

Assets/ Results of Console App:
> ReadMe.md
> Documents and Compared Resultant Document: {RootDirectory}/ConsoleApp/UserFiles 
> Screenshots/ Images: {RootDirectory}/ConsoleApp/Images 

-------------------------------------------------------------------------------------------------------------

Command to Install Aspose.Words Library with different versions
> Install-Package Aspose.Words -Version 21.10.0
> Install-Package Aspose.Words -Version 21.9.0
> Install-Package Aspose.Words -Version 20.1.0
> Install-Package Aspose.Words -Version 22.1.0

-------------------------------------------------------------------------------------------------------------

Document Comparison Description:

> In the 2nd version, "[CCA]Case Management or CM means the functionality within the Software to support...." the 2nd paragraph was removed. 
> The comparison shows the first two words from the 3rd paragraph, where "Client-Developed Code" was impacted and "client" word was redlined and added again (see screenshots in {RootDirectory}/ConsoleApp/Images for reference).

> Similarly in the 3rd version of the document, the 6th, 7th and 8th paragraph which has below mentioned content were removed but the word in the next paragraph i.e. "Developed-Code" of 10th paragraph was red-lined and added again (see screenshots in {RootDirectory}/ConsoleApp/Images for reference).

"[NON -HOSTED] Client-Provided Technology means collectively any Client Materials.... 
Client Reports is defined in Section 34 of Table 2.B. [NTD: Verify Section Number]
[NTD: Include if SI is included scope and Confirm “Software” ...."

> If we compare the version 1 and version 3, then there are content redlined and added again but which were not modfied at all.

Expected Result: The comparison should show only the changes which were performed and the untouched content should be kept as is without redlined and added again.


-------------------------------------------------------------------------------------------------------------
