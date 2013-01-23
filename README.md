# Spark All

Spark All is an open source, general purpose editing program for all RAGE ([Rockstar Advanced Game Engine](http://en.wikipedia.org/wiki/Rockstar_Advanced_Game_Engine)) based games on all major platforms (PC, XBOX 360 and PS3). The list of RAGE based games includes (circa 2013):

- [Rockstar Games Table Tennis](http://en.wikipedia.org/wiki/Rockstar_Games_presents_Table_Tennis)
- [Grand Theft Auto IV](http://en.wikipedia.org/wiki/Grand_Theft_Auto_IV)
- [Midnight Club: Los Angeles](http://en.wikipedia.org/wiki/Midnight_Club:_Los_Angeles)
- [Red Dead Redemption](http://en.wikipedia.org/wiki/Red_Dead_Redemption)
- [Red Dead Redemption: Undead Nightmare](http://en.wikipedia.org/wiki/Red_Dead_Redemption:_Undead_Nightmare)
- [Max Payne 3](http://en.wikipedia.org/wiki/Max_Payne_3)
- [Grand Theft Auto V](http://en.wikipedia.org/wiki/Grand_Theft_Auto_V)

### Project Goals
- To produce a concise, stable, user friendly and useful general purpose editor for all RAGE based games.
- Focus development on creating an application that is able to open all RAGE archives.
- Keep the main code base clean, concise and easy to understand to allow others to learn from it (see the [code guide](http://msdn.microsoft.com/en-us/library/vstudio/ff926074.aspx)).
- Allow community contributions where ever possible and embrace open source software for implementations where possible.
- Provide an example to others in the modding community looking to open source their project or considering a new project.

### Project Origins
Spark All is an evolution of Spark IV. Spark IV is a general purpose editing program for Grand Theft Auto IV. GTA IV is based upon Rockstar's RAGE engine and many of Rockstar's other games also use the RAGE engine, so all of these games share similar architectures and have similar characteristics. Spark All takes advantage of this.

## Versioning
The project branches are defined in the following manner:<br>
**\<Type\>.\<Major Version\>.\<Minor Version\>.\<Revision Version\>**

- **Type**: A string that is 4 characters long,  that defines the content of the branch e.g. WKIP for "work in progress" or NORM for "Normal".
- **Major Version**: An unsigned integer that defines the major milestone of the code base within that branch. 
- **Minor Version**: An unsigned integer that defines the minor milestone of the code base within that branch. 
- **Revision Version**: An unsigned integer that defines the revision (e.g. small bug fix) of the code base within that branch. 

You should increment the major version, minor version and revision version with the following guidelines in mind:

- **Major Version**: Should be updated when a long-term major milestone has been reached. When incremented the minor version and revision version should be reset to 0.
- **Minor Version**: Should be updated when a short-term milestone has been reached. When incremented the revision version should be reset to 0.
- **Revision Version**: Should be updated when a small bug fix or a misc code change has occured.

## Contributing
Since Spark All is an open source project, it embraces community contributions and recognizes the importance of these contributions in achieving the project goals.
### Reporting Bugs
You can easily contribute by simply reporting bugs either via GitHub (by [opening a new issue](https://github.com/cathering/sparkall/issues)) or via the automated bug reporter inside the application. Reporting bugs helps us discover problems in the application and fix them.
### Feature Requests
You can create a feature request by [opening a new issue](https://github.com/cathering/sparkall/issues). Please keep in mind that we have limited labor resources and if your feature is large it may take time to implement or may not be implemented at all. Please note that feature requests must fall in line with the goals of the project.
### Research
Publishing your research on RAGE based games (e.g. file format information) and informing us about your research is also another way to help contribute to the project, as this would save us countless hours.
### Code
In the spirit of the open source philosophy, we encourage the community at large to contribute code to this project. You can contribute code by following these easy steps:

- Fork the master branch of the project.
- Implement your features and code (ensure you are following the [code guide](http://msdn.microsoft.com/en-us/library/vstudio/ff926074.aspx)).
- Test.
- Create a new pull request for the code to be reviewed.

### Notices
- Please do not contribute code that you do not own and if you must use another's code please ensure that it has been released under an [appropriate license](http://www.gnu.org/licenses/license-list.html#GPLCompatibleLicenses).
- All code, comments and lingual contributions must be written in **English (US)** and not your own dialect of English e.g. color (US version) not colour (UK version).
 
## Contributors
- Cathering - primary author of Spark All
- Aru - primary author of Spark IV

## License
This work is released under the [GNU General Public License version 3](http://www.gnu.org/licenses/gpl.txt).