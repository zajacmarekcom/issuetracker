import http from 'k6/http';

export default function () {
    http.post('http://localhost:5001/api/issue', {
        title: 'test perf',
        level: 'Critical',
        occurenceDate: new Date()
    })
}