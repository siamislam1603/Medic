var React = require('react');
const axios = require('axios');

import { List, Avatar, Space } from 'antd';
import { MessageOutlined, LikeOutlined, StarOutlined } from '@ant-design/icons';

const listData = [];
for (let i = 0; i < 23; i++) {
    listData.push({
        href: 'https://ant.design',
        title: `MD. TANVIR HASAN ${i}`,
        avatar: 'https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png',
       
        content:
            'We Faced Problem We Faced Problem We Faced Problem We Faced Problem We Faced Problem We Faced Problem',
    });
}


const IconText = ({ icon, text }) => (
    <Space>
        {React.createElement(icon)}
        {text}
    </Space>
);

class ShowAllPost extends React.Component {
    constructor(props) {
        super(props);
        this.state = { Data: []};
    }

    componentDidMount() {

        fetch("Blog/ShowAllPost")
            .then(
                function (response) {
                    if (response.status !== 200) {
                        console.log('Looks like there was a problem. Status Code: ' +
                            response.status);
                        return;
                    }
                    response.json().then(function (data) {
                        this.setState({
                            Data: data
                        });
                    });
                }
            )
            .catch(function (err) {
                console.log('Fetch Error :-S', err);
            });

      //  console.log(this.state.Data);
     
         /*   fetch("Blog/ShowAllPost3")
                .then(data => {
                    console.log(data);
                    this.setState({ Data: data });
                });
        */
       
    }
     

    render() {

        return (
            <div className="container">
                <List
                    itemLayout="vertical"
                    size="large"
                    pagination={{
                        onChange: page => {
                            console.log(page);
                        },
                        pageSize: 3,
                    }}
                    dataSource={listData}
                    footer={
                        <div>
                            
                        </div>
                    }
                    renderItem={item => (
                        <List.Item
                            key={item.title}
                            actions={[
                                <IconText icon={StarOutlined} text="156" key="list-vertical-star-o" />,
                                <IconText icon={LikeOutlined} text="156" key="list-vertical-like-o" />,
                                <IconText icon={MessageOutlined} text="2" key="list-vertical-message" />,
                            ]}
                            extra={
                                <img
                                    width={272}
                                    alt="logo"
                                  //  src="https://gw.alipayobjects.com/zos/rmsportal/mqaQswcyDLcXyDKnZfES.png"
                                    src="https://w7.pngwing.com/pngs/909/609/png-transparent-physician-illustration-male-doctor-icon-hand-photography-camera-icon.png"
                                />
                            }
                        >
                            <List.Item.Meta
                                avatar={<Avatar src={item.avatar} />}
                                title={<a href={item.href}>{item.title}</a>}
                                
                            />
                            {item.content}
                        </List.Item>
                    )}
                />
            </div>
            
        )
    }
}

export default ShowAllPost; 