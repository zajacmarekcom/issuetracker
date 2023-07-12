import http from 'k6/http';
import { sleep } from 'k6';

export const options = {
    scenarios: {
        issue_perf: {
            executor: 'ramping-vus',
            stages: [
                { duration: '60s', target: 100 },
                { duration: '30s', target: 0 }
            ]
        }
    }
}

export default function () {
    http.post('http://localhost:5001/api/issue', JSON.stringify({
        "title": 'test perf',
        "level": 'Critical',
        occurenceDate: new Date().toISOString()
    }),
    {
        headers: { 'Content-Type': 'application/json' }
    });
}