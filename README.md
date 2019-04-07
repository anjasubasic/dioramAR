# dioramAR
An AR platform for customizing interior design with furniture.

## 💻 Description
DioramAR is an Android application that allows people to use paper cards in the physical world to create furniture arrangements in augmented reality.

Users have access to multiple cards for different furniture types (chair, coffee table, etc.), which they can place in any arrangement on a flat surface. The dioramAR app then uses a smartphone's camera to place three dimensional furniture models obtained through Wayfair's 3D Model API on top of the paper cards. These cards have button icons that users can then tap in the real world to switch between different models of the same furniture type, like switching between coffee tables. The app additionally provides the name of each model of furniture as an overlay in order to make it easier for users to find the furniture on the Wayfair website. 

## 📱 Usage Instructions 
Open the app and arrange the furniture cards. For best results use with good lighting and position the camera close to the furniture cards so printed patterns can be detected easily. To look at different models of furniture, press the button on the furniture card and watch the 3D model/description change. Re-arrange furniture and design your room using dioramAR!

## 📝 Implementation
Python is used to retrieve furniture models using Wayfair's 3D Model API. The models are then loaded into Unity for display. The Vuforia Engine is used to detect the furniture cards for the augmented reality. The 3D model loading functionality, as well as the buttons which allow users to browse furniture were implemented in C#. 
