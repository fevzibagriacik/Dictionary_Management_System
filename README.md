This application made with C# in visual studio. Please, read the README file for use it.

🏁 Getting Started

This is a Windows Forms application developed with C# and MSSQL, allowing users to:

Create their own dictionary.

Track known and unknown words.

Take customized quizzes to reinforce vocabulary.

🧭 Main Menu Overview

Upon launching the app, you will see three main options:

➕ Add Word

Add new words with their meanings.

Mark a word as “unknown” for future practice.

📋 Word List

View all your added words.

See total word count and number of unknown words.

Filter words by status (All / Only Unknown).

Double-click any word to edit or delete it.

🧠 Quiz Mode

Choose between:

Turkish → English or English → Turkish

All words or Only Unknown Words

Set a custom time interval per word.

Start a quiz session with randomized questions.

📊 After Quiz – Results Page

At the end of each quiz, the app will show you:

List of words answered correctly ✅

List of words answered incorrectly ❌

This helps you focus on what to study next.

⚙️ Database

All data is stored in MSSQL LocalDB.

The table TblWord contains fields like:

ID, Word, Meaning, Unknown (bool), IsSelected (bool)

💾 Saving Progress

Every time a word is used in a quiz, its IsSelected field is updated.

You can reset progress by manually clearing this column or using a button (if added in future updates).
