“Let’s Texify”
OCR Application Requirements 
•	An application which is able to read text from an image. Image can be any size, color and font family.
Required Projects.
•	UI Application
o	Image Acquisition
	UI application will be able to read image/Images from the Select Folder Button that pops up in the UI.
	It should also be able to move image signally and also continuously as per specified time delay.
 

o	Recipe Save, Retrieve, show, update and delete
	There should be a feature where we will be able to save all the parameters of a batch. EX.  If I have the image of newspapers & also a book page. Then preprocessing parameters will be different from each other. If we won’t do it then every time we need to change all the parameters.
o	Teaching Process
	There should be a ROI on a panel that is movable.
	We should be able to crop the Image according to the ROI when teach or get data button pressed.
	On clicking on teach data all the parameters that we have decided will be sent to our DLL which will process it further and return a string as an output.
	Then need to call Post processing API that will do the further operation.
 

	There should be a save button that saves the recipe.
	There should also be a feature where we can save the data to any specific file location.


•	OCR DLL
o	Preprocessing
	As per the selected parameters received on the preprocessing function, preprocessing will be done accordingly. 
o	Recognition
	The preprocessed image will be sent to Tesseract.
	It will return a string.
o	Post Processing
	The processed test will be sent to post processing function. 
	It will return the final string.


Roles and responsibilities
•	Ajay
o	Provide the DLL with Preprocessing and Tesseract.
•	Jinoy
o	Provide the DLL with Postprocessing.
•	Vadansh
o	Provide UI with all API calling.




 

