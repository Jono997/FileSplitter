# FileSplitter
 An application that can split files into pieces and stitch them together again

## Usage
### Split
To split a file, select it and specify how large each fragment should be, then click the `Split file` button

### Join
To join a series of fragment files together, switch to the Join tab and drag one of the fragment files onto the window. FileSplitter should automatically find the other fragments if they're all in the same folder and follow the default naming convention.  
After that, select where to save the file and click the `Merge` button.

## Planned features
* An option to specify where to save a fragment series
* An option to split a file into a set number of fragments
* Usability from the command line
* Encrypting files/fragment payloads (both symmetric and asymmetric)

### Other planned changes
* Make Join tab the default [Done]
* Make fragment series detecting more robust [Done]
* Downgrade to the lowest .NET Framework version possible [Abandoned]