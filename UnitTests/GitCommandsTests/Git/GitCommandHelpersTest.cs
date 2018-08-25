﻿using System;
using System.IO;
            // TODO produce a valid working directory
            var module = new GitModule(Path.GetTempPath());
                var fetchCmd = module.FetchCmd("origin", "some-branch", "local").Arguments;
                var fetchCmd = module.FetchCmd("origin", "some-branch", "local", true).Arguments;
                var fetchCmd = module.FetchCmd("https://host.com/repo", "some-branch", "local").Arguments;
                var fetchCmd = module.FetchCmd("https://host.com/repo", "some-branch", null).Arguments;
                var fetchCmd = module.FetchCmd("origin", "", "local").Arguments;
                var fetchCmd = module.PullCmd("origin", "some-branch", false).Arguments;
                var fetchCmd = module.PullCmd("https://host.com/repo", "some-branch", false).Arguments;
                var fetchCmd = module.PullCmd("origin", "some-branch", true).Arguments;
            // TODO produce a valid working directory
            var module = new GitModule(Path.GetTempPath());
                var status = GitCommandHelpers.GetDiffChangedFilesFromString(module, statusString, GitRevision.IndexGuid, GitRevision.WorkTreeGuid, GitRevision.IndexGuid);
            // TODO produce a valid working directory
            var module = new GitModule(Path.GetTempPath());
        public void GetSubmoduleNamesFromDiffTest()
            // TODO produce a valid working directory
            var root = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
            // Create actual working directories so that Process.Start doesn't throw Win32Exception due to an invalid path
            Directory.CreateDirectory(Path.Combine(root, "Externals", "conemu-inside"));
            Directory.CreateDirectory(Path.Combine(root, "Externals", "conemu-inside-a"));
            Directory.CreateDirectory(Path.Combine(root, "Externals", "conemu-inside-b"));
            Directory.CreateDirectory(Path.Combine(root, "Assets", "Core", "Vehicle Physics core assets"));
            var testModule = new GitModule(root);

            try
            {
                // Clean up temporary folders
                Directory.Delete(root, recursive: true);
            }
            catch
            {
                // Ignore
            }
            Assert.AreEqual("submodule sync \"foo\"", GitCommandHelpers.SubmoduleSyncCmd("foo").Arguments);
            Assert.AreEqual("submodule sync", GitCommandHelpers.SubmoduleSyncCmd("").Arguments);
            Assert.AreEqual("submodule sync", GitCommandHelpers.SubmoduleSyncCmd(null).Arguments);
                GitCommandHelpers.AddSubmoduleCmd("remotepath", "localpath", "branch", force: false).Arguments);
                GitCommandHelpers.AddSubmoduleCmd("remotepath", "localpath", branch: null, force: false).Arguments);
                GitCommandHelpers.AddSubmoduleCmd("remotepath", "localpath", "branch", force: true).Arguments);
                GitCommandHelpers.AddSubmoduleCmd("remote\\path", "local\\path", "branch", force: true).Arguments);
            var commitId = ObjectId.Random();

                $"revert {commitId}",
                GitCommandHelpers.RevertCmd(commitId, autoCommit: true, parentIndex: 0).Arguments);
                $"revert --no-commit {commitId}",
                GitCommandHelpers.RevertCmd(commitId, autoCommit: false, parentIndex: 0).Arguments);
                $"revert -m 1 {commitId}",
                GitCommandHelpers.RevertCmd(commitId, autoCommit: true, parentIndex: 1).Arguments);
                GitCommandHelpers.CloneCmd("from", "to").Arguments);
                GitCommandHelpers.CloneCmd("from\\path", "to\\path").Arguments);
                GitCommandHelpers.CloneCmd("from", "to", central: true).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", initSubmodules: true).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", initSubmodules: true).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", depth: 2).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", isSingleBranch: true).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", isSingleBranch: false).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", branch: "branch").Arguments);
                GitCommandHelpers.CloneCmd("from", "to", branch: null).Arguments);
                GitCommandHelpers.CloneCmd("from", "to", lfs: true).Arguments);
                GitCommandHelpers.CheckoutCmd("branch", LocalChangesAction.DontChange).Arguments);
                GitCommandHelpers.CheckoutCmd("branch", LocalChangesAction.Merge).Arguments);
                GitCommandHelpers.CheckoutCmd("branch", LocalChangesAction.Reset).Arguments);
                GitCommandHelpers.CheckoutCmd("branch", LocalChangesAction.Stash).Arguments);
                GitCommandHelpers.RemoveCmd().Arguments);
                GitCommandHelpers.RemoveCmd(force: false).Arguments);
                GitCommandHelpers.RemoveCmd(isRecursive: false).Arguments);
                GitCommandHelpers.RemoveCmd(files: new[] { "a", "b", "c" }).Arguments);
                GitCommandHelpers.BranchCmd("branch", "revision", checkout: true).Arguments);
                GitCommandHelpers.BranchCmd("branch", "revision", checkout: false).Arguments);
                GitCommandHelpers.BranchCmd("branch", null, checkout: true).Arguments);
                GitCommandHelpers.BranchCmd("branch", "", checkout: true).Arguments);
                GitCommandHelpers.BranchCmd("branch", "  ", checkout: true).Arguments);
            Assert.True(GitVersion.Current.PushCanAskForProgress);
                GitCommandHelpers.PushTagCmd("path", "tag", all: false).Arguments);
                GitCommandHelpers.PushTagCmd("path", " tag ", all: false).Arguments);
                GitCommandHelpers.PushTagCmd("path\\path", " tag ", all: false).Arguments);
                GitCommandHelpers.PushTagCmd("path", "tag", all: true).Arguments);
                GitCommandHelpers.PushTagCmd("path", "tag", all: true, force: ForcePushOptions.Force).Arguments);
                GitCommandHelpers.PushTagCmd("path", "tag", all: true, force: ForcePushOptions.ForceWithLease).Arguments);
                GitCommandHelpers.PushTagCmd("path", "", all: false).Arguments);
            Assert.True(GitVersion.Current.StashUntrackedFilesSupported);
                GitCommandHelpers.StashSaveCmd(untracked: false, keepIndex: false, null, Array.Empty<string>()).Arguments);
                GitCommandHelpers.StashSaveCmd(untracked: false, keepIndex: false, null, null).Arguments);
                GitCommandHelpers.StashSaveCmd(untracked: true, keepIndex: false, null, null).Arguments);
                GitCommandHelpers.StashSaveCmd(untracked: false, keepIndex: true, null, null).Arguments);
                GitCommandHelpers.StashSaveCmd(untracked: false, keepIndex: true, null, null).Arguments);
                GitCommandHelpers.StashSaveCmd(untracked: false, keepIndex: false, "message", null).Arguments);
                GitCommandHelpers.StashSaveCmd(untracked: false, keepIndex: false, null, new[] { "a", "b" }).Arguments);
            var id1 = ObjectId.Random();
            var id2 = ObjectId.Random();

                GitCommandHelpers.ContinueBisectCmd(GitBisectOption.Good).Arguments);
                GitCommandHelpers.ContinueBisectCmd(GitBisectOption.Bad).Arguments);
                GitCommandHelpers.ContinueBisectCmd(GitBisectOption.Skip).Arguments);
                $"bisect good {id1} {id2}",
                GitCommandHelpers.ContinueBisectCmd(GitBisectOption.Good, id1, id2).Arguments);
                "-c rebase.autoSquash=false rebase \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: false, preserveMerges: false, autosquash: false, autoStash: false).Arguments);
                "-c rebase.autoSquash=false rebase -i --no-autosquash \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: true, preserveMerges: false, autosquash: false, autoStash: false).Arguments);
                "-c rebase.autoSquash=false rebase --preserve-merges \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: false, preserveMerges: true, autosquash: false, autoStash: false).Arguments);
                "-c rebase.autoSquash=false rebase \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: false, preserveMerges: false, autosquash: true, autoStash: false).Arguments);
                "-c rebase.autoSquash=false rebase --autostash \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: false, preserveMerges: false, autosquash: false, autoStash: true).Arguments);
                "-c rebase.autoSquash=false rebase -i --autosquash \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: true, preserveMerges: false, autosquash: true, autoStash: false).Arguments);
                "-c rebase.autoSquash=false rebase -i --autosquash --preserve-merges --autostash \"branch\"",
                GitCommandHelpers.RebaseCmd("branch", interactive: true, preserveMerges: true, autosquash: true, autoStash: true).Arguments);
                "-c rebase.autoSquash=false rebase \"from\" \"branch\" --onto onto",
                GitCommandHelpers.RebaseCmd("branch", interactive: false, preserveMerges: false, autosquash: false, autoStash: false, "from", "onto").Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: false, directories: false, nonIgnored: true, ignored: false).Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: true, directories: false, nonIgnored: true, ignored: false).Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: false, directories: true, nonIgnored: true, ignored: false).Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: false, directories: false, nonIgnored: false, ignored: false).Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: false, directories: false, nonIgnored: true, ignored: true).Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: false, directories: false, nonIgnored: false, ignored: true).Arguments);
                GitCommandHelpers.CleanUpCmd(dryRun: false, directories: false, nonIgnored: true, ignored: false, "paths").Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default, IgnoreSubmodulesMode.Default).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: false, UntrackedFilesMode.Default, IgnoreSubmodulesMode.Default).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.No, IgnoreSubmodulesMode.Default).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Normal, IgnoreSubmodulesMode.Default).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.All, IgnoreSubmodulesMode.Default).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default, IgnoreSubmodulesMode.None).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default, IgnoreSubmodulesMode.Untracked).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default, IgnoreSubmodulesMode.Dirty).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default, IgnoreSubmodulesMode.All).Arguments);
                GitCommandHelpers.GetAllChangedFilesCmd(excludeIgnoredFiles: true, UntrackedFilesMode.Default, IgnoreSubmodulesMode.Default, noLocks: true).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: false, noCommit: false, allowUnrelatedHistories: false, message: null, log: null, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: false, squash: false, noCommit: false, allowUnrelatedHistories: false, message: null, log: null, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: true, noCommit: false, allowUnrelatedHistories: false, message: null, log: null, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: false, noCommit: true, allowUnrelatedHistories: false, message: null, log: null, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: false, noCommit: false, allowUnrelatedHistories: true, message: null, log: null, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: false, noCommit: false, allowUnrelatedHistories: false, message: "message", log: null, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: false, noCommit: false, allowUnrelatedHistories: false, message: null, log: 0, strategy: null).Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: true, squash: false, noCommit: false, allowUnrelatedHistories: false, message: null, log: null, strategy: "strategy").Arguments);
                GitCommandHelpers.MergeBranchCmd("branch", allowFastForward: false, squash: true, noCommit: true, allowUnrelatedHistories: true, message: "message", log: 1, strategy: "strategy").Arguments);
                GitCommandHelpers.ApplyDiffPatchCmd(false, "hello\\world.patch").Arguments);
                GitCommandHelpers.ApplyDiffPatchCmd(true, "hello\\world.patch").Arguments);
                GitCommandHelpers.ApplyMailboxPatchCmd(false, "hello\\world.patch").Arguments);
                GitCommandHelpers.ApplyMailboxPatchCmd(true, "hello\\world.patch").Arguments);
                GitCommandHelpers.ApplyMailboxPatchCmd(true).Arguments);