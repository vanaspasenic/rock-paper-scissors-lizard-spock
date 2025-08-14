import axios from 'axios';

export class HttpClient {
    private client;

    constructor(baseURL = 'https://localhost:7211') {
        this.client = axios.create({ baseURL });
    }

    public async httpGet<T>(url: string): Promise<T> {
        const response = await this.client.get(url);
        return response.data;
    }

    public async httpPost<T>(url: string, data: any): Promise<T> {
        const response = await this.client.post(url, data);
        return response.data;
    }
}

export const httpClient = new HttpClient();