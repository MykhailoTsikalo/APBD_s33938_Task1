"# APBD_s33938_Task1" 

Git uses fast-forward in case if the target branch (main in our case) has not received any new commits since the feature branch was created. But since we added 
the "Goodbye" line into the Program.cs in the main branch git didn't use fast-forwerd


A merge preserves the exact history of how branches diverged and creates a new "merge commit" to tie them together (resulting in a branched, diamond-shaped 
history). A rebase rewrites the project history by taking the commits from the feature branch and placing them directly on top of the latest main branch.



A conflict was triggered because the exact same line of code (the welcome message in Program.cs) was modified differently on the main branch and the 
feature-conflict branch. To resolve it I manually opened the conflicted file, removed Git's conflict markers (<<<<<<<, =======, >>>>>>>) and manually 
merged both changes into a single working line of code.