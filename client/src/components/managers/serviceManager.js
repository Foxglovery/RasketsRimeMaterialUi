const _apiUrl = "/api/Service";

export const GetServices = () => {
    return fetch(_apiUrl).then((res) => res.json());
}