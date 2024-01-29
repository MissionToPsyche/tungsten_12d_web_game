## Install GitHub LFS tools before cloning the repository

*Install on Mac* \
'brew install git-lfs' \
\
*Once you have lfs installed, git install the tool* \
'git lfs install'

## Cloning the Repo
'git clone SSH' \
\
*You may need to run:* 'git lfs pull' *to ensure the lfs files are downloaded and classified in local*

## Don't push anything to the Main/Master Branch
This serves as our standard version to be released once the project is completed. We also want to make sure if anything breaks we have a working version that can be used to rebase
a broken local repo. Instead, when tasked with creating a new feature/user story/taiga item, start a new branch and then build the feature. The repo manager will handle setting up
merging branches. 

## Creating a new branch
*Check out the current branch and branches you are working on* \
'git branch'

*Create a new branch* \
'git branch <new_branch_name>'

*Move to new branch* \
'git checkout <branch_name>'

## Add, Commit, and Push changes
**Before adding any changes, please double check you are on your feature branch!** \
**Follow this sequence in order -> add, commit, push** \
\
*Add* - You must use this command to add all or specific files to the remote repo \
'git add .' - add everything that has changed \
'git add <specific_file_name>' - add only selected item(s) \

*Commit* - Attaches a message of what was completed/errors/bugs/notes/etc. also mandatory \
'git commit -m "message you want"' \

*Push* -  final step to go from local to remote repo \
'git push'
