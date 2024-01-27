## Install GitHub LFS tools before cloning the repository

*Install on Mac*
'brew install git-lfs'

## Cloning the Repo
'git clone SSH'

## Don't push anything to the Main/Master Branch
This serves as our standard version to be released once the project is completed. We also want to make sure if anything breaks we have a working version that can be used to rebase
a broken local repo. Instead, when tasked with creating a new feature/user story/taiga item, start a new branch and then build the feature. The repo manager will handle setting up
merging branches. 

## Creating a new branch
*Check out the current branch you are working on* \
'git branch'

*Create a new branch* \
'git branch <new branch name>'
