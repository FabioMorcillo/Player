import { Component, Inject, AfterViewInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { CalculaJurosModel } from './calcula-juros-model';

@Component({
  selector: 'app-calcula-juros',
  templateUrl: './calcula-juros.component.html'
})
export class CalculaJurosComponent implements AfterViewInit {
  ngAfterViewInit(): void {
    document.getElementById('valorInicial').focus(); 
    }

  public model: CalculaJurosModel;

  public valorFinal: any;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    this.model = new CalculaJurosModel();
  }

  CalculaJuros() {

    let params = new HttpParams();

    params = params.append('valorInicial', String(this.model.valorInicial));
    params = params.append('meses', String(this.model.meses));

    this.http.get(this.baseUrl + 'api/softplayer/calculajuros', { params: params }).subscribe(result => {
      this.valorFinal = result;
    }, error => console.error(error));
  }
}


