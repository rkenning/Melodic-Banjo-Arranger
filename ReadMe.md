Extract from my blog at : http://diversecollectionofexperiences.blogspot.co.uk/2012/07/malodic-banjo-arranger-part-1.html

Melodic Banjo Arranger Part 1
-----------------------------
As part of a push to develop my skills further and raise my visibility within the coding community, I decided to startup a number of open source projects and hopefully leverage existing source on CodePlex, GitHib etc... to take the pain out of getting a project up and running.

Being a part time musician and a long term fan of the Banjo, one of the projects I have begun working on is a Melodic Banjo tablature Arranger implemented either as self-contained application or plugin module for an existing tablature/music scoring application.

A question some may be asking is why does the world need a Melodic Banjo tablature Arranger?  Or, what the heck is Melodic Banjo?  I don't want to go into too much detail as the this  [Wikipedia](http://en.wikipedia.org/wiki/Keith_style) article explains things very well but its basically a way of playing a melody on the Banjo which encourages as few sequential notes being played on the same string as possible resulting in an overall un-interrupted series of ringing notes.

It is a great style however it is quite time consuming working out the best way to play a given melody in this style as there may be many numbers of ways to play the same note (as with most stringed instruments) but depending on the order of the notes, the current musical phrase and where you last note was fretted it is not immediately obvious what fret & string the next note should be played on.

This I am attempting to help by providing a way to process a MIDI file, pick a track and calculate the best way to arrange the notes in this banjo style.

The second phase would be to allow experimentation of the calculated arrangement allowing the user to fix notes they like and recalculate the remaining 'un-fixed' arranged notes.  I would also like to include the ability to possible open tunings which can be dynamically changed

Finally, the third phase (which is kind of running parallel to the previous two phases) is to wrap the project up in a plug-in to extend an existing app or pull together open source code to display/print the arranged tablature in a usable format and allow the interaction with the arrangement mentioned in phase 2.

I have had an initial play with nAudio which is great at abstracting phrasing of MIDI files however I have been pleasantly surprised at the development of JavaScript music Score/Midi parses projects on Git Hub:


https://github.com/arthurlenoir/DionyScore
https://github.com/GregJ/HTML5-Guitar-Tab-Player
https://github.com/cwilso/Standard-MIDI-File-reader
