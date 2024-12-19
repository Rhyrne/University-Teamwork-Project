import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-business',
  templateUrl: './businesses.component.html',
  styleUrls: ['./businesses.component.scss']
})
export class BusinessesComponent implements OnInit {
  apiUrl: string = 'http://your-backend-url/api/business'; // Backend API URL'nizi yazın
  businessList: any[] = []; // Business listesi
  newBusiness: any = {      // Yeni business ekleme için kullanılan model
    businessId: 0,
    businessName: '',
    businessType: '',
    releaseTime: '',
    userId: 0,
  };

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getBusinesses();
  }

  // Business listeleme
  getBusinesses(): void {
    this.http.get<any[]>(this.apiUrl).subscribe(
      (data) => {
        this.businessList = data;
      },
      (error) => {
        console.error('Error fetching businesses:', error);
      }
    );
  }

  // Yeni business ekleme
  addBusiness(): void {
    this.http.post<any>(this.apiUrl, this.newBusiness).subscribe(
      (response) => {
        this.businessList.push(response); // Yeni business'i listeye ekle
        this.newBusiness = {             // Formu sıfırla
          businessId: 0,
          businessName: '',
          businessType: '',
          releaseTime: '',
          userId: 0,
        };
      },
      (error) => {
        console.error('Error adding business:', error);
      }
    );
  }

  // Business silme
  deleteBusiness(businessId: number): void {
    this.http.delete(`${this.apiUrl}/${businessId}`).subscribe(
      () => {
        this.businessList = this.businessList.filter((business) => business.businessId !== businessId);
      },
      (error) => {
        console.error('Error deleting business:', error);
      }
    );
  }
}
