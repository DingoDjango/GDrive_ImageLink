# GDrive_ImageLink
Parses a Google Drive share link into a convenient &lt;img> tag

# What it does
Google Drive share links are not useful when embedding images, since they are not direct links to the image.
This simple console application takes in a full Drive share link, extracts the file ID and embeds it into an &lt;img> tag (which is my use-case, but is easily modifible in the source code). It then copies the full tag to the Windows clipboard.
