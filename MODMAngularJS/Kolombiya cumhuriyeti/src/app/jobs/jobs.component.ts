import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.scss']
})
export class JobsComponent implements OnInit {
  apiUrl: string = 'http://your-backend-url/api/jobs'; // Backend API URL'nizi yazın
  jobsList: any[] = []; // İş listesi
  newJob: any = {       // Yeni iş ekleme için kullanılan model
    jobId: 0,
    jobTitle: '',
    jobDescription: '',
    releaseTime: '',
    userId: 0,
  };

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getJobs();
  }

  // İşleri listeleme
  getJobs(): void {
    this.http.get<any[]>(this.apiUrl).subscribe(
      (data) => {
        this.jobsList = data;
      },
      (error) => {
        console.error('Error fetching jobs:', error);
      }
    );
  }

  // Yeni iş ekleme
  addJob(): void {
    this.http.post<any>(this.apiUrl, this.newJob).subscribe(
      (response) => {
        this.jobsList.push(response); // Yeni işi listeye ekle
        this.newJob = {              // Formu sıfırla
          jobId: 0,
          jobTitle: '',
          jobDescription: '',
          releaseTime: '',
          userId: 0,
        };
      },
      (error) => {
        console.error('Error adding job:', error);
      }
    );
  }

  // İş silme
  deleteJob(jobId: number): void {
    this.http.delete(`${this.apiUrl}/${jobId}`).subscribe(
      () => {
        this.jobsList = this.jobsList.filter((job) => job.jobId !== jobId);
      },
      (error) => {
        console.error('Error deleting job:', error);
      }
    );
  }
}
