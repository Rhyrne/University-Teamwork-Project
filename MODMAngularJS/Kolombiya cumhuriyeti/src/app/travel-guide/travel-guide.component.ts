import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-travel-guide',
  templateUrl: './travel-guide.component.html',
  styleUrls: ['./travel-guide.component.scss']
})
export class TravelGuideComponent implements OnInit {
  places = [
    {
      name: 'Cartagena de Indias',
      description: 'Kolombiya’nın Karayip sahilindeki bu tarihi şehir, UNESCO Dünya Mirası Listesi’nde yer alır. Renkli sokakları, kolonyal binaları ve Bocagrande plajlarıyla ünlüdür.',
      images: [
       
        'assets/img/faces/kolombiya/cartagena 1.jpg',
         'assets/img/faces/kolombiya/cartagena-2056932_1920.jpg',
          'assets/img/faces/kolombiya/cartagena-2466516_1920.jpg',
           'assets/img/faces/kolombiya/cartagena-3514191_1920.jpg',
            'assets/img/faces/kolombiya/cartagena-de-indias-4788526_1920.jpg',
        
      ]
    },
    {
      name: 'Medellín',
      description: 'Kolombiya’nın inovasyon merkezi Medellín, Comuna 13 grafitileri, çiçek festivalleri ve Arví Park gibi doğa kaçış noktalarıyla öne çıkar.',
      images: [
        'assets/img/faces/kolombiya/medellin-7140474_1920.jpg',
        'assets/img/faces/kolombiya/cable-881759_1920.jpg',
        'assets/img/faces/kolombiya/medellin-2429413_1920.jpg',
        'assets/img/faces/kolombiya/medellin-5991889_1920.jpg',
        'assets/img/faces/kolombiya/stoplight-629102_1920.jpg',
        
        
      ]
    },
    {
      name: 'Amazon Ormanları',
      description: 'Leticia’dan başlayarak Amazon’un zengin biyoçeşitliliğini ve egzotik vahşi yaşamını keşfedebilirsiniz.',
      images: [
        'assets/img/faces/kolombiya/amazon-6977761_1920.jpg',
        'assets/img/faces/kolombiya/amazon-6977773_1920.jpg',
        'assets/img/faces/kolombiya/rainforest-3810953_1920.jpg',
        'assets/img/faces/kolombiya/river-1841419_1920.jpg',
        'assets/img/faces/kolombiya/waterfalls-5089714_1920.jpg',

      ]
    },
    {
      name: 'Tayrona Ulusal Parkı',
      description: 'Karayip sahilindeki bu park, el değmemiş plajları, tropikal ormanları ve Kogi halkının kutsal alanlarıyla doğaseverlerin favorisi.',
      images: [
          'assets/img/faces/kolombiya/tayrona-park-3752794_1920.jpg',
            'assets/img/faces/kolombiya/park-2549997_1920.jpg',
              'assets/img/faces/kolombiya/park-2550000_1920.jpg',
                'assets/img/faces/kolombiya/park-2558917_1920.jpg',

      ]
    },
    {
      name: 'Popayán',
      description: 'Beyaz şehir olarak anılan Popayán, tarihi yapıları ve dini festivalleriyle ziyaretçilerini etkiler.',
      images:[
        'assets/img/faces/kolombiya/Iglesia_de_San_Francisco-Popayan.jpg',
        'assets/img/faces/kolombiya/654GWRUKBZCDNBTY7QQV3PVCYA.avif',
        'assets/img/faces/kolombiya/colombia-3621359_1920.jpg'
        

      ]
    },
    {
      name: 'Barichara',
      description: 'Kolombiya’nın en güzel köylerinden biri olan Barichara, taş sokakları ve Chicamocha Kanyonu’na yakınlığıyla bilinir.',
      images:[
        'assets/img/faces/kolombiya/Barichara-Colombia-Landed-Travel-Private-Travel-1024x680-1.webp',
        'assets/img/faces/kolombiya/barichara-colombia-lightfoot-travel.jpeg',
        'assets/img/faces/kolombiya/barichara-people-santander-colombia.jpg',
        'assets/img/faces/kolombiya/Street_in_Barichara_02.jpg'

      ]
    },
    {
      name: 'Sierra Nevada de Santa Marta',
      description: 'Dünyanın sahile en yakın dağ sistemi, doğa yürüyüşleri ve Kayıp Şehir (Ciudad Perdida) ile büyüler.',
      images: [
        'assets/img/faces/kolombiya/49b03e_f016a9c3132f425aabf86a191809d1de~mv2.avif',
        'assets/img/faces/kolombiya/ciudad perdida.jpg',
        'assets/img/faces/kolombiya/view-of-huts-on-sierra-nevada-de-santa-marta-colombia-south-america-2C52YBC.jpg',
        'assets/img/faces/kolombiya/istockphoto-659580098-612x612.jpg'

      ]
    }
  ];
  selectedPlace: any = null; // Seçilen şehir

  selectPlace(place: any) {
    this.selectedPlace = place; }

  constructor() { }

  ngOnInit(): void {
  }

}
