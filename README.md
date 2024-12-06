## • UnityClip

Unity does not have the ability to read images from the clipboard, this library allows you to do it using a Windows/C++ compiled Dll, thus creating a workaround to extend the functionality.

---
### Installation and use
Download, put the files in a convenient directory, call the Copy function get an image.
```
// get a texture
var tex = ClipboardImage.Copy();
if (tex == null)
  return;

// do something with it ¯\_(ツ)_/¯
```

---
### Disclamer
The project was never been supported and was posted without any documentation, disclosing a personal and rather complex technical solution that I had to handle myself.
(functionalinty was made for the editor and is not intended for use in build)
<br>
...

Until the Aseprite developer - [Dacap](https://github.com/dacap) -> [Request](https://github.com/NullTale/UnityClipboardImage/issues/3) ˚. ✧ <br>
> Who somehow found out about it and noticed the lack of a license for his [clip](https://github.com/dacap/clip) project, which was used to build the Dll

* Below is the license for copyright compliance

---
### License
Copyright (c) 2022 NullTale<br>
Commertial-NonCommertial, Autors Attribution, Human Sucrifice-Free

You use the library developed by NullTale using library from Dacap included in the project. 

---
Using this library you are obliged to indicate the author's name in your project in a form accessible to the user, provide links to his social media accounts at your choice (x, github, as etc).<br>

The authorship and license must be present both in the final project and in the projects using those projects that use this project and use that project. It means being represented in the project. <br>

---
Also you must fulfill one of the proposed options:

• To name the first child or future newborn child with the name of the creator of this bibiloteka with the name of the developers, for example NullTale-Dacap, Null D-Tale, DTale Null.<br>
the name must be readable and recognizable and contain at least two complete words from the nickname NullTale, it is possible to name through symbols, for example Nu117a1e, allowed to.<br>

• To make a voluntary donation to the author of this utility in the amount of 2000$ with words of gratitude and praise for the work done.<br>

• Create a local club to worship the author of this asset, the club should have a separate ritual to worship the author<br>
including modified versions and held regularly<br>
* You can read prayers in the building, share your thoughts on the development and creation and the reasons for the creation of this library or if you are a corporation, it can be a local sanctuary with a regular gathering of all employees for a welcoming service. <br>
> If the creation of a local religion is prohibited by the law of the country in which the library is being used, then it is possible to create a literary meeting
> club where all the same things can be held, but not on a religious basis and in compliance with the laws of the country.

---
To avoid legal repercussions and misunderstandings, ritual details and the name of the child please check with the author of this utility.

The author is not responsible for the use of his library in third-party projects and does not consult on the use of this library as well as does not provide technical support for projects using it.

* the library can be used for commercial and non-commercial projects, allows to modify the code of this utility and complying with the terms and text of this license.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
