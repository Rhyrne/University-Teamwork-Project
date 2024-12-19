import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.scss']
})
export class NewsComponent implements OnInit {
  apiUrl: string = 'http://your-backend-url/api/news'; // Backend API URL'nizi buraya yazın
  newsList: any[] = []; // Haber listesini tutmak için
  newNews: any = {      // Yeni haber eklemek için
    newId: 0,
    newsTitle: '',
    newsDescription: '',
    releaseTime: '',
    userId: 0,
  };

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getNews();
  }

  // Haberleri listeleme
  getNews(): void {
    this.http.get<any[]>(this.apiUrl).subscribe(
      (data) => {
        this.newsList = data;
      },
      (error) => {
        console.error('Error fetching news:', error);
      }
    );
  }

  // Yeni haber ekleme
  addNews(): void {
    this.http.post<any>(this.apiUrl, this.newNews).subscribe(
      (response) => {
        this.newsList.push(response); // Yeni haberi listeye ekle
        this.newNews = {             // Formu sıfırla
          newId: 0,
          newsTitle: '',
          newsDescription: '',
          releaseTime: '',
          userId: 0,
        };
      },
      (error) => {
        console.error('Error adding news:', error);
      }
    );
  }
}
