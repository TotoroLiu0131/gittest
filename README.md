# Git test
請 fork 並下載專案以完成下列幾個需求來確定你熟悉如何使用 git 版本控制
以下測試都不需要 push 回 server，僅需要local commit

測驗如下:
--

1. 請下載這個專案到你的 local repository 並以你的英文名當作資料夾名稱。
2. 請切換到 fix_typo_message 分支並把打錯的訊息從 "WTF" 修改成 "Welcome to Facebook"。commit 數量不變(維持 3 個)
3. 請切換到 forget_commit_file 分支並把無法建置的程式修復(補上 MissingClass )，再重新 commit 上去，條件是 commit 數量不能增加(維持 3 個)。
4. 請切換回 master branch, 並嘗試合併 automerge_but_build_break 分支, 然後查看一下程式是否可以建置, 了解一下 git 自動合併分支是可能出錯的。並新增一個文字檔，說明為什麼會出錯與你會怎麼處理，然後 commit，並建立一個名為 I_got_it 的分支來保留這個 commit。 
5. 請在 master 下指令放棄剛剛的合併, 讓 master 分支回到合併前的版本。
6. 請合併 conflict_resolve 分支，並 commit 到 master。請按照兩個發生衝突的 commit 的 message 來判斷怎麼合併。
7. 因為合併出錯，請使用 revert 指令讓 master 分支回到合併前的狀態，並 commit。
8. 請壓縮這個測驗的資料夾傳給我，代表繳交 SKA。
