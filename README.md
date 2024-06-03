# Let’s Texify

## Project Description

“Let’s Texify” is an OCR (Optical Character Recognition) application capable of reading text from images of any size, color, and font family.

## Application Requirements

### UI Application

#### Image Acquisition
- The UI application allows reading images from a folder selected via the "Select Folder" button.
- It supports both single image and continuous image acquisition based on a specified time delay.

#### Recipe Management
- Save, retrieve, show, update, and delete batch parameters.
- Allows saving different preprocessing parameters for various types of images (e.g., newspapers vs. book pages) to avoid repetitive adjustments.

#### Teaching Process
- A movable ROI (Region of Interest) panel for image cropping.
- Crop images based on the ROI when the "Teach" or "Get Data" button is pressed.
- Parameters sent to a DLL for processing, returning a string output.
- Call a post-processing API for further operations.
- Save button to store recipes.
- Option to save data to a specific file location.

### OCR DLL

#### Preprocessing
- Preprocess images based on selected parameters.

#### Recognition
- Send preprocessed images to Tesseract for text recognition, returning a string.

#### Post Processing
- Send processed text to a post-processing function, returning the final string.

## Roles and Responsibilities

- **Vadansh**
  - Provide the DLL with Preprocessing and Tesseract integration.
  - Develop the UI and integrate all API calls.
  - Provide the DLL with Postprocessing functionality.
