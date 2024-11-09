# Example Solution

This file contains example solutions for each task in the assessment. Use this as a reference for what a complete solution might include in terms of structure, code quality, and comments.

---

## Full-Stack Application Solution (instructions/application.md)

- **Frontend**: A simple React component for adding, viewing, updating, and deleting exam papers.
  ```typescript
  import React, { useState } from 'react';

  const ExamPaperList = () => {
      const [papers, setPapers] = useState([]);
      const fetchPapers = async () => {
          const response = await fetch('/api/exam-papers');
          const data = await response.json();
          setPapers(data);
      };

      return (
          <div>
              <h1>Exam Papers</h1>
              <ul>
                  {papers.map(paper => (
                      <li key={paper.id}>{paper.title}</li>
                  ))}
              </ul>
          </div>
      );
  };

  export default ExamPaperList;

