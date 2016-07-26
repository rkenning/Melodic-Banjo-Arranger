Melodic Banjo Arrangement Tool
==============================

Summary: Project to perform a cost based analysis of melodic Banjo note arrangements


* Read a selected melodic line from a Midi file

* Calculate the various ways of playing each note of the melodic line on banjo (Currently excluding harmonics & alternate tunings 	however the approach should be able to scale to include at some point)

* Allow the definition of costs to be defined for arrangement decisions such as (Large changes in positions between notes, 			multiple notes played on a single string [Not desired for Melodic arrangement])

* Apply a cost based evaluation of every alternative arrangements

* Ultimatly provide a "Best" arrangement of the melodic line

Further detail regards the approaches I have implemented can be found at the blog [link](http://ryankenning.com/2015/07/14/melodic-banjo-project-the-story-so-far/)

Shoutouts to frameworks & guidance regards this project:

[Naudio](https://github.com/naudio/NAudio) - Top notch audio libary which got things off the ground very quickly for me regards parsing of Midi

[alphaTab](https://github.com/CoderLine/alphaTab) - Great Tab rendering libary used to present the arrangements

[MSAGL](https://github.com/Microsoft/automatic-graph-layout) - Microsoft Automatic Graph Layout : Very cool drawing libary used to display the DT node relationships